using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOpenSave_gim_3ti
{
    public partial class Form1 : Form {
        private string fileName;
        private TextInfo _textInfo;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                //MessageBox.Show(openFileDialog1.FileName);
                this.fileName = openFileDialog1.FileName;
                this.Text = this.Text + " - " + openFileDialog1.FileName;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName)) {
                    string line = "";
                    int i = 0;
                    List<string> lines = new List<string>();
                    
                    while ((line = sr.ReadLine()) != null) {
                        lines.Add(line);
                    }
                    //rbDocument.Lines = lines.ToArray();
                    rbDocument.Lines = lines.ToArray();
                    
                    sr.Close();
                    UpdateInfo(lines);
                }
            }
            else {
                //MessageBox.Show(("anuluj"));
            }
        }

        private void UpdateInfo(List<string> lines) {
            _textInfo = _textInfo = new TextInfo(lines);
            lbLines.Text = _textInfo.Lines.ToString();
            lbChars.Text = _textInfo.Chars.ToString();
            lbLetters.Text = _textInfo.Letters.ToString();
        }
        private void OpenNew(object sender, EventArgs e) {
            this.Text = "Okno główne";
            rbDocument.Text = "";

        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.fileName)) {
                saveFileDialog1.FileName = this.fileName;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName,rbDocument.Text);
            }
            else {
                MessageBox.Show("Nie zapisano pliku");
            }
        }

        private void rbDocument_TextChanged(object sender, EventArgs e)
        {
            UpdateInfo(rbDocument.Lines.ToList());
        }
    }
}
