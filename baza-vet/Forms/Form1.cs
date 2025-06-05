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
                        // Próba pobrania danych
                        var animals = context.Vaccinations.ToList();
                        MessageBox.Show("Po³¹czenie z baz¹ dzia³a! Liczba : " + animals.Count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d po³¹czenia z baz¹:\n" + ex.Message);
                }
            
        }
    }
}
