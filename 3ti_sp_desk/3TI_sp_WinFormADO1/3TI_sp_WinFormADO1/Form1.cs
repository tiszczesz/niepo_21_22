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
using _3TI_sp_WinFormADO1.Models;

namespace _3TI_sp_WinFormADO1
{
    public partial class Form1 : Form {
        private Repository repo;
        private List<Book> books;
        
        public Form1() {
            
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            repo = new Repository();
            books = repo.GetAllBooks();
            listOfBooks.DisplayMember = "Title";
            listOfBooks.DataSource = books;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
