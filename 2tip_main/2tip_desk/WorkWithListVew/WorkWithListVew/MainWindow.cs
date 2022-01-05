﻿using System;
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
        public StateOfWin MyStateOfWin { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            gifts = new Gifts();
        }

        public void btnLoad_Click(object sender, EventArgs e) {
            lbGifts.DataSource = null;
            lbGifts.DataSource = gifts.MyGifts;
            lbGifts.DisplayMember = "NamePrice";
            btnAddNewGift.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAddNewGift_Click(object sender, EventArgs e) {
            MyStateOfWin = StateOfWin.Add;
            new NewItem(this).ShowDialog();
            btnLoad_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e) {
            MyStateOfWin = StateOfWin.Edit;
            new NewItem(this).ShowDialog();
        }

        public ListBox GetListBox() {
            return lbGifts;
        }
    }
}
