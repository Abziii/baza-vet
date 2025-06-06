using baza_vet.Modele;
using System.Numerics;
namespace baza_vet.Forms
{
    partial class DoctorForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// private System.ComponentModel.IContainer components = null;

        private System.ComponentModel.IContainer components = null;
        private Doctors _loggedInDoctor;
        public Doctors getDoctor(){return _loggedInDoctor; }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 25);
            button1.Name = "button1";
            button1.Size = new Size(183, 76);
            button1.TabIndex = 0;
            button1.Text = "baza zwierząt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "DoctorForm";
            Text = "Baza-Vet";
            ResumeLayout(false);
        }

        public DoctorForm(Doctors loggedInDoctor)
        {
            InitializeComponent();
            _loggedInDoctor = loggedInDoctor;

            // Przykład użycia:
            //  lblWelcome.Text = $"Witaj, dr {loggedInDoctor.Username}";
        }
        #endregion

        private Button button1;
    }
}