namespace SetMenuWF
{
    public partial class Form1 : Form
    {
        private string _fileName = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbCurrentTime.Text = DateTime.Now.ToShortDateString();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e) {
            new HelpForm().ShowDialog();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e) {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                try
                {
                   StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    rtbDocument.Text = sr.ReadToEnd();
                    sr.Close();
                    _fileName = openFileDialog1.FileName;
                    this.Text += " - " + _fileName;
                }catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                this.Text = "Nie wybrano pliku";
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = _fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(saveFileDialog1.FileName)) {
                    MessageBox.Show("Brak nazwy pliku do zapisu");
                    return;
                }
                var fileToSave = saveFileDialog1.FileName;
                File.WriteAllText(fileToSave,rtbDocument.Text);
            }
        }
    }
}