using Microsoft.EntityFrameworkCore;
using WFormsSqLite1.Data;
using WFormsSqLite1.Models;

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
        }

        private void dataGridViewCakes_MouseDoubleClick(object sender, MouseEventArgs e) {
            //dataGridViewCakes.SelectedRows;
        }
    }
}