namespace AppBiblio.views
{
    partial class ouvrage_add
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
            this.title_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.auteur_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.n_mat_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.theme_cb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.key_words_tb = new MetroFramework.Controls.MetroTextBox();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.cancel_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Titre : ";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(64, 87);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(300, 23);
            this.title_tb.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Auteur : ";
            // 
            // auteur_tb
            // 
            this.auteur_tb.Location = new System.Drawing.Point(77, 132);
            this.auteur_tb.Name = "auteur_tb";
            this.auteur_tb.Size = new System.Drawing.Size(287, 23);
            this.auteur_tb.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "N° :";
            // 
            // n_mat_tb
            // 
            this.n_mat_tb.Location = new System.Drawing.Point(61, 178);
            this.n_mat_tb.Name = "n_mat_tb";
            this.n_mat_tb.Size = new System.Drawing.Size(100, 23);
            this.n_mat_tb.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(167, 178);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Theme : ";
            // 
            // theme_cb
            // 
            this.theme_cb.FormattingEnabled = true;
            this.theme_cb.ItemHeight = 23;
            this.theme_cb.Location = new System.Drawing.Point(233, 178);
            this.theme_cb.Name = "theme_cb";
            this.theme_cb.Size = new System.Drawing.Size(131, 29);
            this.theme_cb.TabIndex = 8;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 227);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Mots clés : ";
            // 
            // key_words_tb
            // 
            this.key_words_tb.Location = new System.Drawing.Point(103, 227);
            this.key_words_tb.Multiline = true;
            this.key_words_tb.Name = "key_words_tb";
            this.key_words_tb.Size = new System.Drawing.Size(259, 110);
            this.key_words_tb.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(286, 344);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Ajouter";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(205, 344);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Annuler";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ouvrage_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 382);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.key_words_tb);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.theme_cb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.n_mat_tb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.auteur_tb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ouvrage_add";
            this.Text = "Ajouter un ouvrage";
            this.Load += new System.EventHandler(this.ouvrage_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox title_tb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox auteur_tb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox n_mat_tb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox theme_cb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox key_words_tb;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroButton cancel_btn;
    }
}