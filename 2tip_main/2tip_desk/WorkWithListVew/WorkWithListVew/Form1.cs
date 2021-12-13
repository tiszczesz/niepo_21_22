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
    public partial class Form1 : Form {
        private Gifts _gifts;
        public Form1()
        {
            InitializeComponent();
            _gifts = new Gifts();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            lbGifts.DataSource = _gifts.MyGifts;
            lbGifts.DisplayMember = "NamePrice";
        }
    }
}
