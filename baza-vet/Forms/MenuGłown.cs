using baza_vet.Data;
using baza_vet.Modele;
namespace baza_vet.Forms
{
    public partial class MenuG�own : Form
    {
        public MenuG�own()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string username = txtUserName.Text;
            string password = txtPassword.Text;

            using var context = new VetClinicContext();
            var doctor = context.Doctors.FirstOrDefault(d => d.Username == username);

            if (doctor == null)
            {
                MessageBox.Show("Nie znaleziono u�ytkownika.");
                return;
            }

            if (!HashHelper.Verify(password, doctor.Password_Hash))
            {
                MessageBox.Show("Nieprawid�owe has�o.");

                return;
            }

            // Zalogowano pomy�lnie

            using (var contextt = new VetClinicContext())
            {

                // Pr�ba pobrania danych

              //  MessageBox.Show("Po��czenie z baz� dzia�a! Liczba zwierzak�w: " + contextt.Animals.Count());
            }

            
            this.Hide();
            var mainForm = new DoctorForm(doctor);
            mainForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bazeVetLabel_Click(object sender, EventArgs e)
        {
            /*
            using (var context = new VetClinicContext())
            {
                foreach (var doc in context.Doctors)
                {
                    if (!doc.Password_Hash.Contains('=')) // bardzo uproszczona detekcja "nie-zahaszowanego"
                    {
                        doc.Password_Hash = HashHelper.HashPassword(doc.Password_Hash);
                    }
                }
                context.SaveChanges();
            }
            */
        }
    }
}
