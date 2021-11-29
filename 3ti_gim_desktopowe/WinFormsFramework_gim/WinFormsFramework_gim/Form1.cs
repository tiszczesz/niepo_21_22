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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void animalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animalsDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animalsDBDataSet.Animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.animalsDBDataSet.Animals);

        }

        private void btnDetails_Click(object sender, EventArgs e) {
            new DetailsWindow().ShowDialog();
        }

        private void animalsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
