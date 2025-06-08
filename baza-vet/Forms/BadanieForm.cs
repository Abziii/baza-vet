using baza_vet.Data;
using baza_vet.Modele;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baza_vet.Forms
{
    public partial class BadanieForm : Form
    {

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gatunek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImieZwierzaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void NazwaWlasciciela_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ImieZwierzakaIn_Click(object sender, EventArgs e)
        {
            ImieZwierzakaIn.Text = animal.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Notatka.Text))
            {
                MessageBox.Show("Potrzebne jest notatka odnośnie badania");

                return;
            }
            var newApointemnt = new Appointments
            {
                Animal_Id = animal.Id,
                Doctor_Id = doktor.Id,
                Appointment_Date = DataZabiegu.Value,
                Notes=Notatka.Text
            };
            
            using (var db = new VetClinicContext())//dodaje badanie do tabeli aappointments
            {
                db.Appointments.Add(newApointemnt);
                db.SaveChanges();
            }
            using(var db = new VetClinicContext())
            {
                var fullAnimal = db.Animals
                    .Include(a => a.doctors)
                    .FirstOrDefault(a => a.Id == animal.Id);

                var fullDoctor = db.Doctors
                                   .FirstOrDefault(d => d.Id == doktor.Id);

                if (fullAnimal != null && fullDoctor != null)
                {
                    // dodaje doktora jezeli nie jest on w liscie 
                    if (!fullAnimal.doctors.Any(d => d.Id == doktor.Id))
                    {
                        fullAnimal.doctors.Add(fullDoctor);
                    }
                }
                db.SaveChanges();
            }
            MessageBox.Show("Badanie zostało dodane.");
            this.Close(); 
            bazaZwierzat.refreshList();
        }

        private void DataZabiegu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
