using System.Globalization;
using Microsoft.EntityFrameworkCore;
using WFormsSqLite1.Data;
using WFormsSqLite1.Models;
using WFormsSqLite1.ViewModel;

namespace WFormsSqLite1
{
    public partial class Form1 : Form {
        private AppDbContext _dbContext;
        public Form1()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }

        private void Form1_Load(object sender, EventArgs e) {
            RepoCake rc = new RepoCake(_dbContext);
            comboBoxBsakery.DataSource = _dbContext.Bakeries.ToList();
            comboBoxBsakery.DisplayMember = "Name";
            comboBoxBsakery.ValueMember = "BakeryId";
            dataGridViewCakes.DataSource = rc.GetWithBakeries();
            dataGridViewCakes.Columns["CakeId"]!.Visible = false;
            dataGridViewCakes.Columns["BakeryId"]!.Visible = false;
            var cc = dataGridViewCakes.Columns;

        }

        private void dataGridViewCakes_MouseDoubleClick(object sender, MouseEventArgs e) {
           var elem =   dataGridViewCakes.SelectedRows[0];
        }

        private void buttonAddCake_Click(object sender, EventArgs e) {
            try {
                string name = textBoxName.Text.Trim();
                decimal price = Convert.ToDecimal(textBoxPrice.Text,CultureInfo.InvariantCulture);
                string description = textBoxDescription.Text.Trim();
                int bakaryId = Convert.ToInt32(comboBoxBsakery.SelectedValue);
                if (name != "" && price >= 0) {
                    Cake c = new Cake { Name = name, Description = description, BakeryId = bakaryId };
                }
                else {
                    MessageBox.Show("B³êdne lub brak danych!!!");
                    return;
                }
                
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
            }
            ;
        }
    }
}