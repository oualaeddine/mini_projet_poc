namespace AppBiblio.views
{
    partial class members_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.members_table = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.n_carte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.members_table)).BeginInit();
            this.SuspendLayout();
            // 
            // members_table
            // 
            this.members_table.AllowUserToAddRows = false;
            this.members_table.AllowUserToDeleteRows = false;
            this.members_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.members_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.prenom,
            this.type,
            this.tel,
            this.matricule,
            this.Genre,
            this.n_carte,
            this.niveau,
            this.date_naissance,
            this.adresse});
            this.members_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.members_table.Location = new System.Drawing.Point(20, 60);
            this.members_table.MultiSelect = false;
            this.members_table.Name = "members_table";
            this.members_table.ReadOnly = true;
            this.members_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.members_table.Size = new System.Drawing.Size(787, 312);
            this.members_table.TabIndex = 0;
            this.members_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.members_table_CellMouseClick);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.Location = new System.Drawing.Point(558, 31);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(179, 23);
            this.metroTextBox1.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.AutoSize = true;
            this.metroButton1.Location = new System.Drawing.Point(743, 31);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(61, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Trouver";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Items.AddRange(new object[] {
            "Etudiant",
            "Enseignant"});
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tel
            // 
            this.tel.HeaderText = "telephone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "matricule";
            this.matricule.Name = "matricule";
            this.matricule.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // n_carte
            // 
            this.n_carte.HeaderText = "n_carte";
            this.n_carte.Name = "n_carte";
            this.n_carte.ReadOnly = true;
            // 
            // niveau
            // 
            this.niveau.HeaderText = "niveau";
            this.niveau.Name = "niveau";
            this.niveau.ReadOnly = true;
            // 
            // date_naissance
            // 
            this.date_naissance.HeaderText = "date de naissance";
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adresse.DefaultCellStyle = dataGridViewCellStyle1;
            this.adresse.HeaderText = "adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // members_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 392);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.members_table);
            this.MaximizeBox = false;
            this.Name = "members_list";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Liste des membres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.members_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.members_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView members_table;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_carte;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
    }
}