using baza_vet.Data;
using baza_vet.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baza_vet.Forms
{
    public partial class BazaZwierzat : Form
    {
        public BazaZwierzat()
        {

            InitializeComponent();

            AnimalsLoad();
        }

        private void AnimalsLoad()
        {

            using (var context = new VetClinicContext())
            {
                var animals = context.Animals.ToList();


                ListBoxAnimals.DataSource = animals;
                ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
            }
        }
        private void button1_Click(object sender, EventArgs e)//cofnij do menu głownego
        {
            this.Hide();

            oknoDoctora.Show();

            this.Close();
        }

        private void ListBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

            var wybranyPacjent = (Animal)ListBoxAnimals.SelectedItem;
            label1.Text = wybranyPacjent.ToString();

        }

        private void button2_Click(object sender, EventArgs e)//twoji pacjenci
        {
            if (button2.Text == "Twoi Pacjenci")
            {
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals.Where(a => a.Id == oknoDoctora.getDoctor().Id).ToList();
                    button2.Text = "Wszyscy Pacjenci";

                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
                }
            }
            else
            {
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals.ToList();
                    button2.Text = "Twoi Pacjenci";

                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)//informache o pacjencie
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
