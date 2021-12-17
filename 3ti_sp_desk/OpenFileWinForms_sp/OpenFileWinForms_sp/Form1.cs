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
using OpenFileWinForms_sp.Models;

namespace OpenFileWinForms_sp
{
    
    public partial class Form1 : Form {
        private string fileName = "";
        private TextInfo textInfo;
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
                    this.fileName = openFileDialog1.FileName;
                    this.Text += " - " + openFileDialog1.FileName;
                    UpdateInfo(rtDocument.Lines.ToList());
                }
                catch (SecurityException ex) {
                    MessageBox.Show($"Błąd wczytania pliku: {ex.Message}");
                }
            }
            else {
                rtDocument.Text = "Nie wybrano pliku!!!!";
            }
        }

        private void UpdateInfo(List<string> data) {
            textInfo = new TextInfo(data);
            lbChars.Text = textInfo.CharCount.ToString();
            lbLetters.Text = textInfo.AlphaCount.ToString();
            lbLines.Text = textInfo.LineCount.ToString();
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
            saveFileDialog1.FileName = this.fileName;
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

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e) {
            rtDocument.SelectionFont = new Font(rtDocument.Font, FontStyle.Bold);

           
           // rtDocument.SelectionStart = 1;
            rtDocument.SelectionLength = 0;
           
            rtDocument.SelectionFont = rtDocument.Font;

            // Reselect previous text
         //   rtDocument.Select(selstart, sellength);
         //   MessageBox.Show(rtDocument.SelectedText);
        }

        private void ustawNormalToolStripMenuItem_Click(object sender, EventArgs e) {
            rtDocument.SelectionFont = new Font(rtDocument.Font, FontStyle.Regular);
            rtDocument.SelectionLength = 0;
            rtDocument.SelectionFont = rtDocument.Font;
        }

        private void rtDocument_TextChanged(object sender, EventArgs e)
        {
            UpdateInfo(rtDocument.Lines.ToList());
        }
    }
}
