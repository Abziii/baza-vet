using System;
using System.Collections.Generic;
using System.ComponentModel;
using baza_vet.Data;
using baza_vet.Forms;

namespace baza_vet.Forms
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//baza zwierzat
        {
            var noweOkno = new BazaZwierzat(this); 
            noweOkno.StartPosition = this.StartPosition;
            this.Hide();
            noweOkno.ShowDialog();
            
          
        }
    }
}
