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
            //var rr = _window.gifts;
            Gift gift = getFromForm();
            ListBox gifts = _window.GetListBox();
            if (gifts.DataSource == null || gifts.SelectedItem == null)
            {
                this.Close();
            }
            Gift toUpdateGift = gifts.SelectedItem as Gift;
            if (gift != null && _window.MyStateOfWin == StateOfWin.Add) {
                _window.gifts.MyGifts.Add(gift);
                Close();
            }else if (gift != null && _window.MyStateOfWin == StateOfWin.Edit) {
               // Gift orginGift = _window.gifts.MyGifts.FirstOrDefault(g=>g.KeyGuid==toUpdateGift.KeyGuid);
               toUpdateGift.Name = gift.Name;
               toUpdateGift.Price = gift.Price;
               toUpdateGift.Description = gift.Description;

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

        private void NewItem_Load(object sender, EventArgs e)
        {
            if (_window.MyStateOfWin == StateOfWin.Edit) {
                this.Text = "Edytuj prezent";
                btnAdd.Text = "Edytuj";
                ListBox gifts = _window.GetListBox();
                if (gifts.DataSource == null || gifts.SelectedItem==null) {
                    this.Close();
                    return;
                }

                Gift selGift = gifts.SelectedItem as Gift;
                UpdateForm(selGift);
            }
            else {
                this.Text = "Dodaj prezent";
                btnAdd.Text = "Dodaj";
            }
        }

        private void UpdateForm(Gift gift) {
            tbName.Text = gift.Name;
            tbPrice.Text = gift.Price.ToString();
            tbDescription.Text = gift.Description;
        }

        private void NewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            _window.btnLoad_Click(_window,null);
        }
    }
}
