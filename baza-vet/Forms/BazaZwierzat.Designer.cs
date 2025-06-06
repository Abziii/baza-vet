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
            label1 = new Label();
            button3 = new Button();
            Edycja = new Button();
            Usun = new Button();
            WyszukajLabel = new Label();
            WyszukajTextBoxx = new TextBox();
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
            ListBoxAnimals.Location = new Point(29, 30);
            ListBoxAnimals.Name = "ListBoxAnimals";
            ListBoxAnimals.Size = new Size(748, 204);
            ListBoxAnimals.TabIndex = 1;
            ListBoxAnimals.SelectedIndexChanged += ListBoxAnimals_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(167, 382);
            button2.Name = "button2";
            button2.Size = new Size(145, 65);
            button2.TabIndex = 2;
            button2.Text = "Twoi Pacjenci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(29, 237);
            label1.Name = "label1";
            label1.Size = new Size(365, 130);
            label1.TabIndex = 3;
            label1.Text = "Informacja o pacjencie";
            label1.Click += label1_Click;
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
            WyszukajLabel.Location = new Point(503, 3);
            WyszukajLabel.Name = "WyszukajLabel";
            WyszukajLabel.Size = new Size(73, 20);
            WyszukajLabel.TabIndex = 7;
            WyszukajLabel.Text = "Wyszukaj:";
            WyszukajLabel.Click += label2_Click;
            // 
            // WyszukajTextBoxx
            // 
            WyszukajTextBoxx.Location = new Point(582, 3);
            WyszukajTextBoxx.Name = "WyszukajTextBoxx";
            WyszukajTextBoxx.Size = new Size(195, 27);
            WyszukajTextBoxx.TabIndex = 8;
            WyszukajTextBoxx.TextChanged += textBox1_TextChanged;
            // 
            // BazaZwierzat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WyszukajTextBoxx);
            Controls.Add(WyszukajLabel);
            Controls.Add(Usun);
            Controls.Add(Edycja);
            Controls.Add(button3);
            Controls.Add(label1);
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
        private Label label1;
        private Button button3;
        private Button Edycja;
        private Button Usun;
        private Label WyszukajLabel;
        private TextBox WyszukajTextBoxx;
    }
}