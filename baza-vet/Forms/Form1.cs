namespace baza_vet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                try
                {
                    using (var context = new VetClinicContext())
                    {
                        // Pr�ba pobrania danych
                        var animals = context.Vaccinations.ToList();
                        MessageBox.Show("Po��czenie z baz� dzia�a! Liczba : " + animals.Count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B��d po��czenia z baz�:\n" + ex.Message);
                }
            
        }
    }
}
