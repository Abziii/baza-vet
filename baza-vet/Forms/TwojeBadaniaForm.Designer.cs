using baza_vet.Data;

namespace baza_vet.Forms
{
    partial class TwojeBadaniaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public TwojeBadaniaForm(DoctorForm oknoDoctora)
        {
            InitializeComponent();
            this.oknoDoctora = oknoDoctora;
             LoadBadania();
        }
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
            CofnijB = new Button();
            pnlBadania = new Panel();
            SuspendLayout();
            // 
            // CofnijB
            // 
            CofnijB.Location = new Point(12, 373);
            CofnijB.Name = "CofnijB";
            CofnijB.Size = new Size(145, 65);
            CofnijB.TabIndex = 1;
            CofnijB.Text = "Cofnij do menu głownego";
            CofnijB.UseVisualStyleBackColor = true;
            CofnijB.Click += button1_Click;
            // 
            // pnlBadania
            // 
            pnlBadania.AutoScroll = true;
            pnlBadania.Location = new Point(3, 2);
            pnlBadania.Name = "pnlBadania";
            pnlBadania.Size = new Size(782, 360);
            pnlBadania.TabIndex = 2;
            pnlBadania.Paint += pnlBadania_Paint;
            // 
            // TwojeBadaniaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBadania);
            Controls.Add(CofnijB);
            Name = "TwojeBadaniaForm";
            Text = "TwojeBadaniaForm";
            ResumeLayout(false);
        }


        #endregion

        private Button CofnijB;
        private DoctorForm oknoDoctora;
        private Panel pnlBadania;
    }
}