using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baza_vet.Data;
using baza_vet.Modele;
using Microsoft.EntityFrameworkCore;
namespace baza_vet.Forms
{
    public partial class DodajZwierzeForm : Form
    {
        private Animal animal;
        private int doctorId;
        private BazaZwierzat bazaZwierzat;
        public DodajZwierzeForm(int DoctorId,BazaZwierzat bazaZwierzat)
        {
            InitializeComponent();
            doctorId = DoctorId;
            this.bazaZwierzat = bazaZwierzat;
        }
        public DodajZwierzeForm(int DoctorId,Animal dane, BazaZwierzat bazaZwierzat)
        {
            InitializeComponent2(dane);
            doctorId = DoctorId;
            animal = dane;
            this.bazaZwierzat = bazaZwierzat;
        }
        private void button1_Click(object sender, EventArgs e)//cofnij
        {
            Hide();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//wyslij
        {
            if(button2.Text=="Dodaj")
            {
                if (string.IsNullOrWhiteSpace(ImieZwierzaka.Text) || string.IsNullOrWhiteSpace(NazwaWlasciciela.Text)  || string.IsNullOrWhiteSpace(gatunek.Text) )
                {
                    MessageBox.Show("Potrzebne jest minimum:\nImie Zwierzaka,Nazwa Właściciela oraz gatunek");

                    return;
                }
                var newAnimal = new Animal
                {
                    Name = ImieZwierzaka.Text,
                    Owner_Name = NazwaWlasciciela.Text,
                    Birth_Date = DataUrodzenia.Value,
                    Breed = rasa.Text,
                    Species = gatunek.Text,
                    

                };

                using (var db = new VetClinicContext())
                {
                    db.Animals.Add(newAnimal);
                    db.SaveChanges();
                }

                MessageBox.Show("Pacjent został dodany.");
                this.Close(); 
                bazaZwierzat.refreshList();
            }
            else//edycja
            {
                if (string.IsNullOrWhiteSpace(ImieZwierzaka.Text) || string.IsNullOrWhiteSpace(NazwaWlasciciela.Text)  || string.IsNullOrWhiteSpace(gatunek.Text) )
                {
                    MessageBox.Show("Potrzebne jest minimum:\nImie Zwierzaka,Nazwa Właściciela oraz gatunek");

                    return;
                } 
                using (var db = new VetClinicContext())
                {
                var newAnimal = new Animal
                {
                    Name = ImieZwierzaka.Text,
                    Owner_Name = NazwaWlasciciela.Text,
                    Birth_Date = DataUrodzenia.Value,
                    Breed = rasa.Text,
                    Species = gatunek.Text,
                    

                };
                    var oldAnimal = db.Animals.Find(animal.Id);
                    oldAnimal.Name = newAnimal.Name;
                    oldAnimal.Owner_Name = newAnimal.Owner_Name;
                    oldAnimal.Birth_Date = newAnimal.Birth_Date;
                    oldAnimal.Breed = newAnimal.Breed;
                    oldAnimal.Species = newAnimal.Species;
                    


                    db.SaveChanges();
                }


                MessageBox.Show("Zapisano zmiany.");

                
                this.Close(); // zamknij formularz po dodaniu
                bazaZwierzat.refreshList();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//imie zwierzaka
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//data urodzenia
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//nazwa wlasciciela
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//rasa
        {

        }
    }
}
