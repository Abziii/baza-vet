using baza_vet.Modele;

namespace baza_vet.Forms
{
    partial class BazaZwierzat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DoctorForm oknoDoctora;
        private bool sortowanie = false;
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
        public BazaZwierzat(DoctorForm oknoDoctora)
        {
            InitializeComponent();
            this.oknoDoctora = oknoDoctora;
            AnimalsLoad();
            // Przykład użycia:
            //  lblWelcome.Text = $"Witaj, dr {loggedInDoctor.Username}";
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ListBoxAnimals = new ListBox();
            button2 = new Button();
            InformacjaPacjentLabel = new Label();
            button3 = new Button();
            Edycja = new Button();
            Usun = new Button();
            WyszukajLabel = new Label();
            WyszukajTextBoxx = new TextBox();
            BadaniaLabel = new Label();
            DodajBadanie = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 382);
            button1.Name = "button1";
            button1.Size = new Size(145, 65);
            button1.TabIndex = 0;
            button1.Text = "Cofnij do menu głownego";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListBoxAnimals
            // 
            ListBoxAnimals.BackColor = SystemColors.ActiveCaption;
            ListBoxAnimals.FormattingEnabled = true;
            ListBoxAnimals.Location = new Point(29, 36);
            ListBoxAnimals.Name = "ListBoxAnimals";
            ListBoxAnimals.Size = new Size(748, 204);
            ListBoxAnimals.TabIndex = 1;
            ListBoxAnimals.SelectedIndexChanged += ListBoxAnimals_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(366, 6);
            button2.Name = "button2";
            button2.Size = new Size(122, 27);
            button2.TabIndex = 2;
            button2.Text = "Twoi Pacjenci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InformacjaPacjentLabel
            // 
            InformacjaPacjentLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            InformacjaPacjentLabel.Location = new Point(29, 243);
            InformacjaPacjentLabel.Name = "InformacjaPacjentLabel";
            InformacjaPacjentLabel.Size = new Size(345, 100);
            InformacjaPacjentLabel.TabIndex = 3;
            InformacjaPacjentLabel.Text = "Informacja o pacjencie";
            InformacjaPacjentLabel.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(330, 382);
            button3.Name = "button3";
            button3.Size = new Size(145, 65);
            button3.TabIndex = 4;
            button3.Text = "Dodaj Pacjenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Edycja
            // 
            Edycja.Location = new Point(481, 382);
            Edycja.Name = "Edycja";
            Edycja.Size = new Size(145, 65);
            Edycja.TabIndex = 5;
            Edycja.Text = "Edytuj Pacjenta";
            Edycja.UseVisualStyleBackColor = true;
            Edycja.Click += Edycja_Click;
            // 
            // Usun
            // 
            Usun.Location = new Point(632, 382);
            Usun.Name = "Usun";
            Usun.Size = new Size(145, 65);
            Usun.TabIndex = 6;
            Usun.Text = "Usuń Pacjenta";
            Usun.UseVisualStyleBackColor = true;
            Usun.Click += Usun_Click;
            // 
            // WyszukajLabel
            // 
            WyszukajLabel.AutoSize = true;
            WyszukajLabel.Location = new Point(503, 9);
            WyszukajLabel.Name = "WyszukajLabel";
            WyszukajLabel.Size = new Size(73, 20);
            WyszukajLabel.TabIndex = 7;
            WyszukajLabel.Text = "Wyszukaj:";
            WyszukajLabel.Click += label2_Click;
            // 
            // WyszukajTextBoxx
            // 
            WyszukajTextBoxx.Location = new Point(582, 6);
            WyszukajTextBoxx.Name = "WyszukajTextBoxx";
            WyszukajTextBoxx.Size = new Size(195, 27);
            WyszukajTextBoxx.TabIndex = 8;
            WyszukajTextBoxx.TextChanged += textBox1_TextChanged;
            // 
            // BadaniaLabel
            // 
            BadaniaLabel.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BadaniaLabel.Location = new Point(380, 243);
            BadaniaLabel.Name = "BadaniaLabel";
            BadaniaLabel.Size = new Size(386, 114);
            BadaniaLabel.TabIndex = 8;
            BadaniaLabel.Text = "Badania:";
            BadaniaLabel.Click += Badania_Click;
            // 
            // DodajBadanie
            // 
            DodajBadanie.Location = new Point(167, 383);
            DodajBadanie.Name = "DodajBadanie";
            DodajBadanie.Size = new Size(157, 62);
            DodajBadanie.TabIndex = 9;
            DodajBadanie.Text = "Dodaj Badanie";
            DodajBadanie.UseVisualStyleBackColor = true;
            DodajBadanie.Click += DodajBadanie_Click;
            // 
            // BazaZwierzat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DodajBadanie);
            Controls.Add(BadaniaLabel);
            Controls.Add(WyszukajTextBoxx);
            Controls.Add(WyszukajLabel);
            Controls.Add(Usun);
            Controls.Add(Edycja);
            Controls.Add(button3);
            Controls.Add(InformacjaPacjentLabel);
            Controls.Add(button2);
            Controls.Add(ListBoxAnimals);
            Controls.Add(button1);
            Name = "BazaZwierzat";
            Text = "BazaZwierzat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox ListBoxAnimals;
        private Button button2;
        private Label InformacjaPacjentLabel;
        private Button button3;
        private Button Edycja;
        private Button Usun;
        private Label WyszukajLabel;
        private TextBox WyszukajTextBoxx;
        private Label BadaniaLabel;
        private Button DodajBadanie;
    }
}