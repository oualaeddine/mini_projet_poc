namespace AppBiblio.views
{
    partial class Login
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
            this.connect_btn = new MetroFramework.Controls.MetroButton();
            this.annuler_btn = new MetroFramework.Controls.MetroButton();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(186, 161);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connexion";
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // annuler_btn
            // 
            this.annuler_btn.Location = new System.Drawing.Point(105, 161);
            this.annuler_btn.Name = "annuler_btn";
            this.annuler_btn.Size = new System.Drawing.Size(75, 23);
            this.annuler_btn.TabIndex = 1;
            this.annuler_btn.Text = "annuler";
            this.annuler_btn.Click += new System.EventHandler(this.annuler_btn_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(23, 118);
            this.password.Name = "password";
            this.password.PromptText = "Mot de passe";
            this.password.Size = new System.Drawing.Size(238, 23);
            this.password.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(23, 67);
            this.email.Name = "email";
            this.email.PromptText = "Email";
            this.email.Size = new System.Drawing.Size(238, 23);
            this.email.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.annuler_btn);
            this.Controls.Add(this.connect_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton connect_btn;
        private MetroFramework.Controls.MetroButton annuler_btn;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox email;
    }
}