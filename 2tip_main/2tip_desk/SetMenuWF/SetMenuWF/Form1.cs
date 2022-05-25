namespace SetMenuWF
{
    public partial class Form1 : Form
    {
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
                //todo
            }
        }
    }
}