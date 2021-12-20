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
    public partial class NewItem : Form {
        private MainWindow _window;
        public NewItem(MainWindow window=null)
        {
            InitializeComponent();
            _window = window;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var rr = _window.gifts;
            Gift gift = getFromForm();
            if (gift != null) {
                _window.gifts.MyGifts.Add(gift);
                Close();
            }
        }

        private Gift getFromForm() {
            try {
                string name = tbName.Text.Trim();
                decimal price = Convert.ToDecimal(tbPrice.Text);
                string description = tbDescription.Text.Trim();
                return new Gift {Name = name, Price = price, Description = description};
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
            }

            return null;

        }
    }
}
