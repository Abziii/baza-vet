using baza_vet.Modele;

namespace baza_vet.Forms
{
    partial class DodajZwierzeForm
    {
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
            label2 = new Label();
            ImieZwierzaka = new TextBox();
            gatunek = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DataUrodzenia = new DateTimePicker();
            NazwaWlasciciela = new TextBox();
            rasa = new TextBox();
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
            button2.Location = new Point(163, 464);
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
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Gatunek:";
            label2.Click += label2_Click;
            // 
            // ImieZwierzaka
            // 
            ImieZwierzaka.Location = new Point(125, 16);
            ImieZwierzaka.Name = "ImieZwierzaka";
            ImieZwierzaka.Size = new Size(153, 27);
            ImieZwierzaka.TabIndex = 4;
            ImieZwierzaka.TextChanged += textBox1_TextChanged;
            // 
            // gatunek
            // 
            gatunek.FormattingEnabled = true;
            gatunek.Items.AddRange(new object[] { "Kot", "Pies", "Ptak", "Chomik", "Inne" });
            gatunek.Location = new Point(125, 56);
            gatunek.Name = "gatunek";
            gatunek.Size = new Size(151, 28);
            gatunek.TabIndex = 5;
            gatunek.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Rasa:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 148);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 7;
            label4.Text = "Nazwa właściciela:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 192);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 8;
            label5.Text = "Data Urodzenia:";
            label5.Click += label5_Click;
            // 
            // DataUrodzenia
            // 
            DataUrodzenia.Format = DateTimePickerFormat.Short;
            DataUrodzenia.Location = new Point(131, 192);
            DataUrodzenia.Name = "DataUrodzenia";
            DataUrodzenia.Size = new Size(145, 27);
            DataUrodzenia.TabIndex = 9;
            DataUrodzenia.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // NazwaWlasciciela
            // 
            NazwaWlasciciela.Location = new Point(142, 145);
            NazwaWlasciciela.Name = "NazwaWlasciciela";
            NazwaWlasciciela.Size = new Size(125, 27);
            NazwaWlasciciela.TabIndex = 10;
            NazwaWlasciciela.TextChanged += textBox2_TextChanged;
            // 
            // rasa
            // 
            rasa.Location = new Point(125, 102);
            rasa.Name = "rasa";
            rasa.Size = new Size(153, 27);
            rasa.TabIndex = 11;
            rasa.TextChanged += textBox3_TextChanged;
            // 
            // DodajZwierzeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 523);
            Controls.Add(rasa);
            Controls.Add(NazwaWlasciciela);
            Controls.Add(DataUrodzenia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(gatunek);
            Controls.Add(ImieZwierzaka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DodajZwierzeForm";
            Text = "Dodaj Pacjenta";
            ResumeLayout(false);
            PerformLayout();
        }
        private void InitializeComponent2(Animal dane)
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ImieZwierzaka = new TextBox();
            gatunek = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DataUrodzenia = new DateTimePicker();
            NazwaWlasciciela = new TextBox();
            rasa = new TextBox();
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
            button2.Location = new Point(163, 464);
            button2.Name = "button2";
            button2.Size = new Size(107, 58);
            button2.TabIndex = 1;
            button2.Text = "Edytuj";
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
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Gatunek:";
            label2.Click += label2_Click;
            // 
            // ImieZwierzaka
            // 
            ImieZwierzaka.Location = new Point(125, 16);
            ImieZwierzaka.Name = "ImieZwierzaka";
            ImieZwierzaka.Size = new Size(153, 27);
            ImieZwierzaka.TabIndex = 4;
            ImieZwierzaka.TextChanged += textBox1_TextChanged;
            ImieZwierzaka.Text = dane.Name;
            // 
            // gatunek
            // 
            gatunek.FormattingEnabled = true;
            gatunek.Items.AddRange(new object[] { "Kot", "Pies", "Ptak", "Chomik", "Inne" });
            gatunek.Location = new Point(125, 56);
            gatunek.Name = "gatunek";
            gatunek.Size = new Size(151, 28);
            gatunek.TabIndex = 5;
            gatunek.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            if(dane.Species.Length > 0)
            {
            gatunek.SelectedItem= gatunek.Items[gatunek.Items.IndexOf(dane.Species)];
            }
            else
            {
                gatunek.SelectedItem = gatunek.Items[0];
            }
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Rasa:";
            label3.Click += label3_Click;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 148);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 7;
            label4.Text = "Nazwa właściciela:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 192);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 8;
            label5.Text = "Data Urodzenia:";
            label5.Click += label5_Click;
            // 
            // DataUrodzenia
            // 
            DataUrodzenia.Format = DateTimePickerFormat.Short;
            DataUrodzenia.Location = new Point(131, 192);
            DataUrodzenia.Name = "DataUrodzenia";
            DataUrodzenia.Size = new Size(145, 27);
            DataUrodzenia.TabIndex = 9;
            DataUrodzenia.ValueChanged += dateTimePicker1_ValueChanged;
            DataUrodzenia.Value= (System.DateTime) dane.Birth_Date;
            // 
            // NazwaWlasciciela
            // 
            NazwaWlasciciela.Location = new Point(142, 145);
            NazwaWlasciciela.Name = "NazwaWlasciciela";
            NazwaWlasciciela.Size = new Size(125, 27);
            NazwaWlasciciela.TabIndex = 10;
            NazwaWlasciciela.TextChanged += textBox2_TextChanged;
            NazwaWlasciciela.Text = dane.Owner_Name;
            // 
            // rasa
            // 
            rasa.Location = new Point(125, 102);
            rasa.Name = "rasa";
            rasa.Size = new Size(153, 27);
            rasa.TabIndex = 11;
            rasa.TextChanged += textBox3_TextChanged;
            rasa.Text =dane.Breed;
            // 
            // DodajZwierzeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 523);
            Controls.Add(rasa);
            Controls.Add(NazwaWlasciciela);
            Controls.Add(DataUrodzenia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(gatunek);
            Controls.Add(ImieZwierzaka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DodajZwierzeForm";
            Text = "Edytuj Pacjenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox ImieZwierzaka;
        private ComboBox gatunek;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker DataUrodzenia;
        private TextBox NazwaWlasciciela;
        private TextBox rasa;
    }
}