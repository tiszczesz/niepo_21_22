using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppfirst
{
    public partial class OtherWindow : Form
    {
        public OtherWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            label1.Text = "Hello world from\n WindowsForms";
        }

        private void Kliknieto(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
