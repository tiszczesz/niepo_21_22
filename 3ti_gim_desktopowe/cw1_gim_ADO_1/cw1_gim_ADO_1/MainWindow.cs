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
            string coonection = Properties.Settings.Default.connString;
            InitializeComponent();
            
        }

    }
}
