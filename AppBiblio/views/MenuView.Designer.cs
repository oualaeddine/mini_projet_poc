namespace AppBiblio
{
    partial class MenuView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_member = new MetroFramework.Controls.MetroTile();
            this.members_list = new MetroFramework.Controls.MetroTile();
            this.banned_list = new MetroFramework.Controls.MetroTile();
            this.add_ouvrage = new MetroFramework.Controls.MetroTile();
            this.ouvrages_list = new MetroFramework.Controls.MetroTile();
            this.settings = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.connected_name = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // add_member
            // 
            this.add_member.Location = new System.Drawing.Point(23, 63);
            this.add_member.Name = "add_member";
            this.add_member.Size = new System.Drawing.Size(217, 125);
            this.add_member.Style = MetroFramework.MetroColorStyle.Purple;
            this.add_member.TabIndex = 0;
            this.add_member.Text = "Ajouter un membre";
            this.add_member.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.add_member.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.add_member.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // members_list
            // 
            this.members_list.Location = new System.Drawing.Point(246, 63);
            this.members_list.Name = "members_list";
            this.members_list.Size = new System.Drawing.Size(217, 125);
            this.members_list.Style = MetroFramework.MetroColorStyle.Blue;
            this.members_list.TabIndex = 1;
            this.members_list.Text = "Liste membres";
            this.members_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.members_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.members_list.Click += new System.EventHandler(this.members_list_Click);
            // 
            // banned_list
            // 
            this.banned_list.Location = new System.Drawing.Point(469, 63);
            this.banned_list.Name = "banned_list";
            this.banned_list.Size = new System.Drawing.Size(217, 125);
            this.banned_list.Style = MetroFramework.MetroColorStyle.Red;
            this.banned_list.TabIndex = 2;
            this.banned_list.Text = "Liste membres bannis";
            this.banned_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.banned_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.banned_list.Click += new System.EventHandler(this.banned_list_Click);
            // 
            // add_ouvrage
            // 
            this.add_ouvrage.Location = new System.Drawing.Point(23, 194);
            this.add_ouvrage.Name = "add_ouvrage";
            this.add_ouvrage.Size = new System.Drawing.Size(217, 125);
            this.add_ouvrage.Style = MetroFramework.MetroColorStyle.Green;
            this.add_ouvrage.TabIndex = 3;
            this.add_ouvrage.Text = "Ajouter un ouvrage";
            this.add_ouvrage.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.add_ouvrage.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.add_ouvrage.Click += new System.EventHandler(this.add_ouvrage_Click);
            // 
            // ouvrages_list
            // 
            this.ouvrages_list.Location = new System.Drawing.Point(246, 194);
            this.ouvrages_list.Name = "ouvrages_list";
            this.ouvrages_list.Size = new System.Drawing.Size(217, 125);
            this.ouvrages_list.Style = MetroFramework.MetroColorStyle.Brown;
            this.ouvrages_list.TabIndex = 4;
            this.ouvrages_list.Text = "Liste des ouvrages";
            this.ouvrages_list.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ouvrages_list.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ouvrages_list.Click += new System.EventHandler(this.ouvrages_list_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(468, 194);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(217, 125);
            this.settings.Style = MetroFramework.MetroColorStyle.Silver;
            this.settings.TabIndex = 5;
            this.settings.Text = "Parametres";
            this.settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.settings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 322);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Connecté en tant que : ";
            // 
            // connected_name
            // 
            this.connected_name.Location = new System.Drawing.Point(174, 322);
            this.connected_name.Name = "connected_name";
            this.connected_name.Size = new System.Drawing.Size(511, 23);
            this.connected_name.TabIndex = 7;
            this.connected_name.Text = "Berrehal Ouala Eddine";
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 341);
            this.Controls.Add(this.connected_name);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.ouvrages_list);
            this.Controls.Add(this.add_ouvrage);
            this.Controls.Add(this.banned_list);
            this.Controls.Add(this.members_list);
            this.Controls.Add(this.add_member);
            this.MaximizeBox = false;
            this.Name = "MenuView";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BiblioGest v1.0";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile add_member;
        private MetroFramework.Controls.MetroTile members_list;
        private MetroFramework.Controls.MetroTile banned_list;
        private MetroFramework.Controls.MetroTile add_ouvrage;
        private MetroFramework.Controls.MetroTile ouvrages_list;
        private MetroFramework.Controls.MetroTile settings;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel connected_name;
    }
}

