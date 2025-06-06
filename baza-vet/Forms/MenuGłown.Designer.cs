namespace baza_vet.Forms
{
    partial class MenuGłown
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(304, 201);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(282, 98);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(157, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(282, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(200, 94);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 3;
            label1.Text = "Login:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(200, 154);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 4;
            label2.Text = "Hasło:";
            label2.Click += label2_Click;
            // 
            // MenuGłown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(button1);
            Name = "MenuGłown";
            Text = "Baza-Vet";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private Button button1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}
