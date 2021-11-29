using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFramework_gim
{
    public partial class DetailsWindow : Form
    {
        public DetailsWindow()
        {
            InitializeComponent();
        }

       

        private void DetailsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animalsDBDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.animalsDBDataSet1.DataTable1);
            


        }
    }
}
