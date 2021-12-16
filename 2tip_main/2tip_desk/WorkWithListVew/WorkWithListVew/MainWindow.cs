using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithListVew.Models;

namespace WorkWithListVew
{
    public partial class MainWindow : Form {
        public Gifts gifts;
        public MainWindow()
        {
            InitializeComponent();
            gifts = new Gifts();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            lbGifts.DataSource = gifts.MyGifts;
            lbGifts.DisplayMember = "NamePrice";
        }

        private void btnAddNewGift_Click(object sender, EventArgs e) {
            new NewItem(this).ShowDialog();
        }
    }
}
