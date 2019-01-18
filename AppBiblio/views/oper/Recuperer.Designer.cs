namespace AppBiblio.views.oper
{
    partial class Recuperer
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.matricule = new MetroFramework.Controls.MetroTextBox();
            this.recuperer_btn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(247, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Veuillez entrer le matricule de l\'ouvrage :";
            // 
            // matricule
            // 
            this.matricule.Location = new System.Drawing.Point(23, 95);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(247, 23);
            this.matricule.TabIndex = 1;
            // 
            // recuperer_btn
            // 
            this.recuperer_btn.Location = new System.Drawing.Point(196, 124);
            this.recuperer_btn.Name = "recuperer_btn";
            this.recuperer_btn.Size = new System.Drawing.Size(75, 23);
            this.recuperer_btn.TabIndex = 2;
            this.recuperer_btn.Text = "Recuperer";
            this.recuperer_btn.Click += new System.EventHandler(this.recuperer_btn_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(115, 124);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "annuler";
            this.metroButton2.Click += new System.EventHandler(this.annuler_Click);
            // 
            // Recuperer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 164);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.recuperer_btn);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Recuperer";
            this.Text = "Recuperer";
            this.Load += new System.EventHandler(this.Recuperer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox matricule;
        private MetroFramework.Controls.MetroButton recuperer_btn;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}