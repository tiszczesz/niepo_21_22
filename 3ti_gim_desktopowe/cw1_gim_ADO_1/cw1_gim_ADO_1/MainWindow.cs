using cw1_gim_ADO_1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw1_gim_ADO_1.Models;


namespace cw1_gim_ADO_1
{
    public partial class MainWindow : Form {
        public Repository repo;
        public MainWindow() {
            repo = new Repository();
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e) {
           
            List<Animal> animal = repo.getAllAnimalsSpecies();
            listAnimals.DisplayMember = "Name";
            listAnimals.DataSource = animal;
        }

        private void listAnimals_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = listAnimals.SelectedIndex;
            Animal animal = (Animal) listAnimals.SelectedItem;
           // MessageBox.Show(listAnimals.SelectedIndex.ToString());
           UpdateDetails(animal);
        }

        private void UpdateDetails(Animal animal) {
            if (animal != null) {
                tbName.Text = animal.Name;
                tbDescription.Text = animal.Description;
                Image image = Image.FromFile(Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "images/"+animal.Image));
                picAnimal.Image = image;
                tbSpecies.Text = animal.Species.Name;
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e) {
            new AddNew(this).ShowDialog();
        }
    }
}
