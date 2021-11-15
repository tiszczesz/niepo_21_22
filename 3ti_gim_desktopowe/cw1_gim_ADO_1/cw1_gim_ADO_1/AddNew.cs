using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw1_gim_ADO_1.DAL;
using cw1_gim_ADO_1.Models;

namespace cw1_gim_ADO_1
{
    public partial class AddNew : Form {
        private MainWindow _mainWindow;
        private Repository _repo;
        public List<Species> species { get; set; }
        public AddNew(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _repo = mainWindow.repo;
        }

        private void AddNew_Load(object sender, EventArgs e) {
            species = _repo.getAllSpecies();
            cbSpecies.DataSource = species;
            cbSpecies.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Animal toSaveAnimal = new Animal() {
                Name = tbName.Text,
                Description = tbDescription.Text,
                SpeciesId = ((Species) cbSpecies.SelectedItem).Id
            };
            _repo.InsertAnimal(toSaveAnimal);
            _mainWindow.UploadAnimals();
            Close();
        }
    }
}
