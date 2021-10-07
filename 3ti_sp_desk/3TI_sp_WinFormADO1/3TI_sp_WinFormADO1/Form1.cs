using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3TI_sp_WinFormADO1.DAL;

namespace _3TI_sp_WinFormADO1
{
    public partial class Form1 : Form {
        private Repository repo;

        
        public Form1() {
            
            InitializeComponent();
            repo = new Repository();
        }

    }
}
