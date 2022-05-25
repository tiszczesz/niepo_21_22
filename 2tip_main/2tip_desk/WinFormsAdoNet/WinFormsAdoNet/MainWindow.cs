using System.Diagnostics;
using WinFormsAdoNet.Models;

namespace WinFormsAdoNet
{
    public partial class MainWindow : Form {
        private SQLRepo _repo;
        public MainWindow()
        {
            InitializeComponent();
            _repo = new SQLRepo();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            List<Worker> workers = _repo.GetWorkers();
            listBox1.DataSource = workers;
            dataGridView1.DataSource = workers;
            dataGridView1.Columns["Id"]!.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            Process.Start("notepad.exe");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            MessageBox.Show(e.ToString());
        }
    }
}