using cw1_gim_ADO_1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cw1_gim_ADO_1
{
    public partial class MainWindow : Form
    {
        public MainWindow() {
            
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Repository repo = new Repository();
        }
    }
}
