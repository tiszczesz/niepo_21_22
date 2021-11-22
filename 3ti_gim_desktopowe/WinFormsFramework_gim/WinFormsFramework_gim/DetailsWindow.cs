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

        private void animalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.animalsDBDataSet);

        }

        private void DetailsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animalsDBDataSet.Species' table. You can move, or remove it, as needed.
            this.speciesTableAdapter.Fill(this.animalsDBDataSet.Species);
            // TODO: This line of code loads data into the 'animalsDBDataSet.Animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.animalsDBDataSet.Animals);

        }
    }
}
