namespace AppBiblio.views.ouvrages
{
    partial class Ouvrage_list
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
            this.ouvrages_table = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keywords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrages_table)).BeginInit();
            this.SuspendLayout();
            // 
            // ouvrages_table
            // 
            this.ouvrages_table.AllowUserToAddRows = false;
            this.ouvrages_table.AllowUserToDeleteRows = false;
            this.ouvrages_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ouvrages_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titre,
            this.Auteur,
            this.Theme,
            this.Matricule,
            this.Keywords});
            this.ouvrages_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrages_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ouvrages_table.Location = new System.Drawing.Point(20, 60);
            this.ouvrages_table.MultiSelect = false;
            this.ouvrages_table.Name = "ouvrages_table";
            this.ouvrages_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ouvrages_table.Size = new System.Drawing.Size(708, 369);
            this.ouvrages_table.TabIndex = 0;
            this.ouvrages_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ouvrages_table_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Theme";
            this.Theme.Name = "Theme";
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            // 
            // Keywords
            // 
            this.Keywords.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Keywords.HeaderText = "Mots Clés";
            this.Keywords.Name = "Keywords";
            // 
            // Ouvrage_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.ouvrages_table);
            this.MaximizeBox = false;
            this.Name = "Ouvrage_list";
            this.Resizable = false;
            this.Text = "Ouvrage_list";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ouvrage_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ouvrages_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ouvrages_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keywords;
    }
}