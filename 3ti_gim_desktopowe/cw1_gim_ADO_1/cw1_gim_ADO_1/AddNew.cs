using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw1_gim_ADO_1.DAL;

namespace cw1_gim_ADO_1
{
    public partial class AddNew : Form {
        private MainWindow _mainWindow;
        private Repository _repo;
        public AddNew(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _repo = mainWindow.repo;
        }
    }
}
