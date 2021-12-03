using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileWinForms_sp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    rtDocument.Text = sr.ReadToEnd();
                    sr.Close();
                    this.Text += " - " + openFileDialog1.FileName;
                }
                catch (SecurityException ex) {
                    MessageBox.Show($"Błąd wczytania pliku: {ex.Message}");
                }
            }
            else {
                rtDocument.Text = "Nie wybrano pliku!!!!";
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e) {
            rtDocument.Text = "";
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    if (saveFileDialog1.FileName == "") {
                        MessageBox.Show("Brak nazwy pliku!!");
                        return;
                    }
                    var filePath = saveFileDialog1.FileName;
                    File.WriteAllText(filePath,rtDocument.Text);
                    rtDocument.Text = "";
                    this.Text = "Form1";
                }catch(SecurityException ex) {
                    MessageBox.Show("Błąd zapisu: " + ex.Message);
                }
            }
            else {
                MessageBox.Show("nie zapisano pliku!!!");
            }
        }
    }
}
