using AppBiblio.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppBiblio
{
    public partial class MenuView : MetroFramework.Forms.MetroForm
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            connected_name.Text = "Berrehal Ouala Eddine.";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new member_add().Show();
        }

        private void members_list_Click(object sender, EventArgs e)
        {
            new members_list().Show();
        }

        private void banned_list_Click(object sender, EventArgs e)
        {
            new members_banned_list().Show();
        }

        private void add_ouvrage_Click(object sender, EventArgs e)
        {
            new ouvrage_add().Show();
        }

        private void ouvrages_list_Click(object sender, EventArgs e)
        {
            new ouvrage_list().Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }
    }
}
