using baza_vet.Modele;
using System.Numerics;
using System.Security.Cryptography;

namespace baza_vet.Forms
{
    partial class BadanieForm
    {
        private Animal animal;
        private Doctors doktor;
        private BazaZwierzat bazaZwierzat;
        public BadanieForm(Animal animal, Doctors doktor, BazaZwierzat bazaZwierzat)
        {
            this.animal = animal;
            this.doktor = doktor;
            this.bazaZwierzat = bazaZwierzat;
            InitializeComponent();
            if (doktor != null)
            {
                DoktorIn.Text = $"Dr. {doktor.First_Name} {doktor.Last_Name}";
            }
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            button2 = new Button();
            label1 = new Label();
            Doktor = new Label();
            NotatkaLabel = new Label();
            DataZabieguL = new Label();
            DataZabiegu = new DateTimePicker();
            Notatka = new TextBox();
            ImieZwierzakaIn = new Label();
            DoktorIn = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 464);
            button1.Name = "button1";
            button1.Size = new Size(107, 58);
            button1.TabIndex = 0;
            button1.Text = "Cofnij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 464);
            button2.Name = "button2";
            button2.Size = new Size(107, 58);
            button2.TabIndex = 1;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Imię Zwierzaka:";
           
            // 
            // Doktor
            // 
            Doktor.AutoSize = true;
            Doktor.Location = new Point(7, 59);
            Doktor.Name = "Doktor";
            Doktor.Size = new Size(58, 20);
            Doktor.TabIndex = 3;
            Doktor.Text = "Doktor:";
            Doktor.Click += label2_Click;
            // 
            // NotatkaLabel
            // 
            NotatkaLabel.AutoSize = true;
            NotatkaLabel.Location = new Point(7, 237);
            NotatkaLabel.Name = "NotatkaLabel";
            NotatkaLabel.Size = new Size(65, 20);
            NotatkaLabel.TabIndex = 7;
            NotatkaLabel.Text = "Notatka:";
            // 
            // DataZabieguL
            // 
            DataZabieguL.AutoSize = true;
            DataZabieguL.Location = new Point(7, 192);
            DataZabieguL.Name = "DataZabieguL";
            DataZabieguL.Size = new Size(103, 20);
            DataZabieguL.TabIndex = 8;
            DataZabieguL.Text = "Data Zabiegu:";
            DataZabieguL.Click += label5_Click;
            // 
            // DataZabiegu
            // 
            DataZabiegu.Location = new Point(131, 192);
            DataZabiegu.MinDate = DateTime.Today;
            DataZabiegu.Name = "DataZabiegu";
            DataZabiegu.Size = new Size(145, 27);
            DataZabiegu.TabIndex = 9;
            DataZabiegu.ValueChanged += DataZabiegu_ValueChanged;
            // 
            // Notatka
            // 
            Notatka.Location = new Point(7, 272);
            Notatka.Name = "Notatka";
            Notatka.Size = new Size(296, 27);
            Notatka.TabIndex = 10;
            Notatka.TextChanged += NazwaWlasciciela_TextChanged;
            // 
            // ImieZwierzakaIn
            // 
            ImieZwierzakaIn.AutoSize = true;
            ImieZwierzakaIn.Location = new Point(143, 19);
            ImieZwierzakaIn.Name = "ImieZwierzakaIn";
            ImieZwierzakaIn.Size = new Size(0, 20);
            ImieZwierzakaIn.TabIndex = 11;
            ImieZwierzakaIn.Click += ImieZwierzakaIn_Click;
            ImieZwierzakaIn.Text = animal.Name;
            // 
            // DoktorIn
            // 
            DoktorIn.AutoSize = true;
            DoktorIn.Location = new Point(84, 59);
            DoktorIn.Name = "DoktorIn";
            DoktorIn.Size = new Size(0, 20);
            DoktorIn.TabIndex = 12;
            DoktorIn.Text = "dr";
        
            
            // 
            // BadanieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 523);
            Controls.Add(DoktorIn);
            Controls.Add(ImieZwierzakaIn);
            Controls.Add(Notatka);
            Controls.Add(DataZabiegu);
            Controls.Add(DataZabieguL);
            Controls.Add(NotatkaLabel);
            Controls.Add(Doktor);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BadanieForm";
            Text = "Dodaj Pacjenta";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Label label1;
        private Label Doktor;
        private Label NotatkaLabel;
        private Label DataZabieguL;
        private DateTimePicker DataZabiegu;
        private TextBox Notatka;
        #endregion

        private Label ImieZwierzakaIn;
        private Label DoktorIn;
    }
}