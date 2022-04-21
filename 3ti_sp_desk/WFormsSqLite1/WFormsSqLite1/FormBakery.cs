using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFormsSqLite1.Data;

namespace WFormsSqLite1
{
    public partial class FormBakery : Form {
        private readonly AppDbContext _db;

        public FormBakery(AppDbContext db) {
            _db = db;
            InitializeComponent();
        }

        private void FormBakery_Load(object sender, EventArgs e) {
            var bakaries = _db.Bakeries.ToList();
            dataGridView1.DataSource = bakaries;
        }
    }
}
