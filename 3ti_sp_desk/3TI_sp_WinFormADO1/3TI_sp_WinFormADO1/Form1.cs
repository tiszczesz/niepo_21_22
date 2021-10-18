using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private void listOfBooks_DoubleClick(object sender, EventArgs e) {
            if (listOfBooks.DataSource == null) {
                MessageBox.Show("Brak załadowanych danych");
                return;
            }
            Book book = (Book)listOfBooks.SelectedItem;
        //    MessageBox.Show(book.Title + " " + book.Author);
            if (book != null) {
                UpdateForm(book);
            }
        }

        private void UpdateForm(Book b) {
            tbTitle.Text = b.Title;
            tbAuthor.Text = b.Author;
            tbPrice.Text = b.Price.ToString();
            tbDescription.Text = b.Description;
            Image image = Image.FromFile(Path.Combine(
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location), "Images/"
                                                               + (b.Image!="" ? b.Image : "no_image.jpg")));
            pbImage.Image = image;
        }

       
    }
}
