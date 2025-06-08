using baza_vet.Data;
using baza_vet.Modele;
namespace baza_vet.Forms
{
    public partial class MenuG³own : Form
    {
        public MenuG³own()
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
                MessageBox.Show("Nie znaleziono u¿ytkownika.");
                return;
            }

            if (!HashHelper.Verify(password, doctor.Password_Hash))
            {
                MessageBox.Show("Nieprawid³owe has³o.");
                
                return;
            }

            // Zalogowano pomyœlnie

            using (var contextt = new VetClinicContext())
            {

                // Próba pobrania danych
                
                MessageBox.Show("Po³¹czenie z baz¹ dzia³a! Liczba zwierzaków: " + contextt.Animals.Count());
            }
            
            MessageBox.Show($"Witaj, dr {doctor.First_Name}!");
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
    }
}
