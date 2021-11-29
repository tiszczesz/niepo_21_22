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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) {
            new OtherWindow().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                double a = Convert.ToDouble(tbA.Text);
                double b = Convert.ToDouble(tbB.Text);
                lbResult.Text = (a + b).ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show("Błąd konwersji na liczbę: " + ex.Message);
            }
           
        }
    }
}
