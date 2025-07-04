﻿using baza_vet.Data;
using baza_vet.Modele;
using Microsoft.EntityFrameworkCore;

using System.Data;


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
            InformacjaPacjentLabel.Text = wybranyPacjent.ToString();
            using (var context = new VetClinicContext())
            {
                var appointments = context.Appointments
                .Where(a => a.Animal_Id == wybranyPacjent.Id)
                .OrderBy(a => a.Appointment_Date)
                .ToList();

                BadaniaLabel.Text = "Badania:";

                foreach (var appointment in appointments)
                {
                    var dr = context.Doctors.FirstOrDefault(d => d.Id == appointment.Doctor_Id);


                    if (dr != null)
                    {
                        BadaniaLabel.Text += $"\n{appointment.Appointment_Date:yyyy-MM-dd}: {dr.First_Name} {dr.Last_Name} - {appointment.Notes}";
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)//twoi pacjenci
        {
            WyszukajTextBoxx.Text = "";
            if (button2.Text == "Twoi Pacjenci")
            {
                sortowanie = true;
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals
            .Include(a => a.doctors)
            .Where(a => a.doctors.Any(d => d.Id == oknoDoctora.getDoctor().Id))
            .ToList();
                    button2.Text = "Wszyscy Pacjenci";

                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); 
                }
            }
            else
            {
                sortowanie = false;
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals.ToList();
                    button2.Text = "Twoi Pacjenci";

                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); 
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)//informache o pacjencie
        {

        }

        private void button3_Click(object sender, EventArgs e)//dodaj pacjenta
        {
            var oknoDodaj = new DodajZwierzeForm(oknoDoctora.getDoctor().Id, this);
            oknoDodaj.ShowDialog();
        }

        private void Edycja_Click(object sender, EventArgs e)
        {
            var oknoDodaj = new DodajZwierzeForm(oknoDoctora.getDoctor().Id, (Animal)ListBoxAnimals.SelectedItem, this);

            oknoDodaj.ShowDialog();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            var wybranyPacjent = (Animal)ListBoxAnimals.SelectedItem;
            var confirm = MessageBox.Show($"Na pewno usunąć tego pacjenta?\n{wybranyPacjent.Name}", "Potwierdź", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new VetClinicContext())
                {
                    db.Animals.Remove(wybranyPacjent);
                    db.SaveChanges();
                }

                MessageBox.Show("Pacjent został usunięty.");
                refreshList();
            }
        }
        public void refreshList()
        {
            WyszukajTextBoxx.Text = "";
            if (sortowanie)
            {
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals.Where(a => a.Id == oknoDoctora.getDoctor().Id).ToList();


                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
                }


            }
            else
            {
                using (var context = new VetClinicContext())
                {
                    var animals = context.Animals.ToList();


                    ListBoxAnimals.DataSource = animals;
                    ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//wyszukiwarka
        {
            using (var context = new VetClinicContext())
            {
                var animals = context.Animals.Where(a => a.Name.Contains(WyszukajTextBoxx.Text) || a.Breed.Contains(WyszukajTextBoxx.Text) || a.Owner_Name.Contains(WyszukajTextBoxx.Text) || a.Species.Contains(WyszukajTextBoxx.Text)).ToList();
                if (sortowanie)
                {
                    animals = context.Animals.Where(a => a.Id == oknoDoctora.getDoctor().Id && (a.Name.Contains(WyszukajTextBoxx.Text) || a.Breed.Contains(WyszukajTextBoxx.Text)
                                   || a.Owner_Name.Contains(WyszukajTextBoxx.Text) || a.Species.Contains(WyszukajTextBoxx.Text))).ToList();

                }

                ListBoxAnimals.DataSource = animals;
                ListBoxAnimals.DisplayMember = animals.ToString(); // lub inna właściwość
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Badania_Click(object sender, EventArgs e)
        {

        }

        private void DodajBadanie_Click(object sender, EventArgs e)
        {
            var oknoBadanie = new BadanieForm((Animal)ListBoxAnimals.SelectedItem, oknoDoctora.getDoctor(),this);
            oknoBadanie.ShowDialog();
        }
    }
}
