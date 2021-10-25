using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using _3TI_sp_WinFormADO1.DAL;
using _3TI_sp_WinFormADO1.Models;

namespace _3TI_sp_WinFormADO1 {
    public partial class Form1 : Form {
        private List<Book> books;
        private Repository repo;

        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            repo = new Repository();
            books = repo.GetAllBooks();
            listOfBooks.DisplayMember = "Title";
            listOfBooks.DataSource = books;
            btnAddNew.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void listOfBooks_DoubleClick(object sender, EventArgs e) {
            if (listOfBooks.DataSource == null) {
                MessageBox.Show("Brak załadowanych danych");
                return;
            }

            var book = (Book) listOfBooks.SelectedItem;
            //    MessageBox.Show(book.Title + " " + book.Author);
            if (book != null) UpdateForm(book);
        }

        private void UpdateForm(Book b) {
            tbTitle.Text = b.Title;
            tbAuthor.Text = b.Author;
            tbPrice.Text = b.Price.ToString();
            tbDescription.Text = b.Description;
            var image = Image.FromFile(Path.Combine(
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location), "Images/"
                                                               + (b.Image != "" ? b.Image : "no_image.jpg")));
            pbImage.Image = image;
        }

        private void ClearForm() {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbPrice.Text = "";
            tbDescription.Text = "";
            //Image image = Image.FromFile(Path.Combine(
            //    Path.GetDirectoryName(
            //        Assembly.GetExecutingAssembly().Location), "Images/"
            //                                                   + (b.Image != "" ? b.Image : "no_image.jpg")));
            pbImage.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearForm();
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            //bez walidacji!!!
            var b = new Book();
            b.Title = tbTitle.Text;
            b.Author = tbAuthor.Text;
            b.Price = Convert.ToDecimal(tbPrice.Text);
            b.Description = tbDescription.Text;
            b.Image = "";
            repo.Insert(b);
            ClearForm();
            btnLoad_Click(this, e);
        }
    }
}