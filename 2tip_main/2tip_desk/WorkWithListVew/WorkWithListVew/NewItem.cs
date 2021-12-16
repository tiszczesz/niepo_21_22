using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
