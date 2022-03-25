using System.Globalization;
using WFormsSqLite1.Data;
using WFormsSqLite1.Models;
using WFormsSqLite1.ViewModel;

namespace WFormsSqLite1; 

public partial class Form1 : Form {
    private readonly AppDbContext _dbContext;
    private RepoCake rc;
    private bool isEdit = false;

    public Form1() {
        InitializeComponent();
        _dbContext = new AppDbContext();
    }

    private void FillDataGrid() {
        dataGridViewCakes.DataSource = rc.GetWithBakeries();
        dataGridViewCakes.Columns["CakeId"]!.Visible = false;
        dataGridViewCakes.Columns["BakeryId"]!.Visible = false;
        var cc = dataGridViewCakes.Columns;
    }

    private void ClearTextBoxes() {
        textBoxName.Text = "";
        textBoxDescription.Text = "";
        textBoxPrice.Text = "";
    }

    private void Form1_Load(object sender, EventArgs e) {
        rc = new RepoCake(_dbContext);
        comboBoxBsakery.DataSource = _dbContext.Bakeries.ToList();
        comboBoxBsakery.DisplayMember = "Name";
        comboBoxBsakery.ValueMember = "BakeryId";
        FillDataGrid();
    }

    private void dataGridViewCakes_MouseDoubleClick(object sender, MouseEventArgs e) {
        var elem = dataGridViewCakes.SelectedRows[0];
    }

    private void buttonAddCake_Click(object sender, EventArgs e) {
        try {
            var name = textBoxName.Text.Trim();
            var price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture);
            var description = textBoxDescription.Text.Trim();
            var bakaryId = Convert.ToInt32(comboBoxBsakery.SelectedValue);
            if (name != "" && price >= 0) {
                var cake = new Cake { Name = name, 
                    Description = description, 
                    BakeryId = bakaryId,
                    Price = price};
                if (isEdit == false) {
                    
                    _dbContext.Cakes.Add(cake);
                    _dbContext.SaveChanges();
                }
                else {
                    var row = (CakesWithBakery)dataGridViewCakes.SelectedRows[0].DataBoundItem;
                    Cake cakeToUpdate = _dbContext.Cakes.Find(row.CakeId);
                    if (cakeToUpdate != null) {
                        cakeToUpdate.Name = textBoxName.Text.Trim();
                        cakeToUpdate.Price = Convert.ToDecimal(textBoxPrice.Text, CultureInfo.InvariantCulture);
                        cakeToUpdate.BakeryId = Convert.ToInt32(comboBoxBsakery.SelectedValue);
                        cakeToUpdate.Description = textBoxDescription.Text.Trim();
                        _dbContext.Cakes.Update(cakeToUpdate);
                        _dbContext.SaveChanges();
                        buttonAddCake.Text = "Dodaj ciastko";
                    }
                }
                
                ClearTextBoxes();
                FillDataGrid();
            }
            else {
                MessageBox.Show("B³êdne lub brak danych!!!");
            }
        }
        catch (FormatException ex) {
            MessageBox.Show(ex.Message);
        }

        ;
    }

    private void button1_Click(object sender, EventArgs e) {
        if (dataGridViewCakes.SelectedRows.Count == 0) {
            MessageBox.Show("Musisz wybraæ ciastko do usuniêcia!!");
            return;
        }
        var row = (CakesWithBakery)dataGridViewCakes.SelectedRows[0].DataBoundItem;
        if (row != null) {
            var c = _dbContext.Cakes.Find(row.CakeId);
            _dbContext.Cakes.Remove(c);
            _dbContext.SaveChanges();
            FillDataGrid();
        }
    }

    private void dataGridViewCakes_DoubleClick(object sender, EventArgs e)
    {
        if (dataGridViewCakes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Musisz wybraæ ciastko do edycji!!");
            return;
        }

        isEdit = true;
        var row = (CakesWithBakery)dataGridViewCakes.SelectedRows[0].DataBoundItem;
        Cake c = _dbContext.Cakes.Find(row.CakeId);
        if (c != null) {
            textBoxName.Text = c.Name;
            textBoxPrice.Text = c.Price.ToString(CultureInfo.InvariantCulture);
            textBoxDescription.Text = c?.Description;
            comboBoxBsakery.SelectedValue = c.BakeryId;
        }

        buttonAddCake.Text = "Zapisz zmiany";
    }
}

