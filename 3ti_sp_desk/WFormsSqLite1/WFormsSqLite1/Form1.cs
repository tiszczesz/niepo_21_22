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

            dataGridViewCakes.DataSource = rc.GetWithBakeries();
            dataGridViewCakes.Columns["CakeId"]!.Visible = false;
            dataGridViewCakes.Columns["BakeryId"]!.Visible = false;
            var cc = dataGridViewCakes.Columns;
        }

        private void dataGridViewCakes_MouseDoubleClick(object sender, MouseEventArgs e) {
           var elem =   dataGridViewCakes.SelectedRows[0];
        }
    }
}