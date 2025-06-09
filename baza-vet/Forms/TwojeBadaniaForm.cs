using baza_vet.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baza_vet.Forms
{
    public partial class TwojeBadaniaForm : Form
    {


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            oknoDoctora.Show();

            this.Close();
        }

        private void pnlBadania_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadBadania()
        {
            pnlBadania.Controls.Clear(); // wyczyść stare elementy

            int doctorId = oknoDoctora.getDoctor().Id;

            using (var context = new VetClinicContext())
            {
                ;
                var badania = context.Appointments
                    .Where(a => a.Doctor_Id == doctorId)
                    .OrderBy(a => a.Appointment_Date)
                    .Take(20)
                    .ToList();

                int y = 10;

                foreach (var appointment in badania)
                {
                    string dzienTygodnia = appointment.Appointment_Date.Value.DayOfWeek.ToString();
                    if (appointment.Appointment_Date.Value.Date.Equals(DateTime.Today))
                    {
                        dzienTygodnia = "Dzisiaj";
                    }
                    // label z datą i tytułem
                    var lbl = new System.Windows.Forms.Label()
                    {
                        Text = $"{appointment.Appointment_Date:dd-MM-yyyy}| { dzienTygodnia} |{appointment.Notes}",
                        
                        Location = new Point(10, y),
                        Size = new Size(40, 61),
            
                        AutoSize = true
                    };

                    // przycisk odwolaj
                    var btn = new Button
                    {
                        Text = "Odwołaj",
                        Size = new Size(40, 40),
                        Location = new Point(400, y - 2),
                        Tag = appointment.Id, // zapamiętaj ID badania
                        Width = 80
                    };
                    btn.Click += Odwolaj_Click;

                    pnlBadania.Controls.Add(lbl);
                    pnlBadania.Controls.Add(btn);

                    y += 35;
                }

                if (badania.Count == 0)
                {
                    var lblBrak = new System.Windows.Forms.Label()
                    {
                        Text = "Brak zaplanowanych badań.",
                        Size = new Size(50, 50),
                        Location = new Point(10, 10),
                        AutoSize = true
                    };
                    pnlBadania.Controls.Add(lblBrak);
                }
            }
        }
        private void Odwolaj_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int appointmentId)
            {
                var confirm = MessageBox.Show("Czy na pewno chcesz odwołać to badanie?", "Potwierdź", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var context = new VetClinicContext())
                    {
                        var appointment = context.Appointments.FirstOrDefault(a => a.Id == appointmentId);
                        if (appointment != null)
                        {
                            context.Appointments.Remove(appointment);
                            context.SaveChanges();
                            MessageBox.Show("Badanie odwołane.");
                        }
                    }

                    LoadBadania(); // odśwież listę
                }
            }
        }
    }
}
