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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 382);
            button1.Name = "button1";
            button1.Size = new Size(176, 65);
            button1.TabIndex = 0;
            button1.Text = "Cofnij do menu głownego";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListBoxAnimals
            // 
            ListBoxAnimals.BackColor = SystemColors.ActiveCaption;
            ListBoxAnimals.FormattingEnabled = true;
            ListBoxAnimals.Location = new Point(29, 10);
            ListBoxAnimals.Name = "ListBoxAnimals";
            ListBoxAnimals.Size = new Size(706, 224);
            ListBoxAnimals.TabIndex = 1;
            ListBoxAnimals.SelectedIndexChanged += ListBoxAnimals_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(208, 382);
            button2.Name = "button2";
            button2.Size = new Size(162, 65);
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
            button3.Location = new Point(392, 382);
            button3.Name = "button3";
            button3.Size = new Size(162, 65);
            button3.TabIndex = 4;
            button3.Text = "Dodaj Pacjenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BazaZwierzat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(ListBoxAnimals);
            Controls.Add(button1);
            Name = "BazaZwierzat";
            Text = "BazaZwierzat";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox ListBoxAnimals;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}