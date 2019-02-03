using System;
using System.Windows.Forms;
using AppBiblio.views;
using AppBiblio.views.members;
using AppBiblio.views.oper;
using AppBiblio.views.ouvrages;

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
            //connected_name.Text = "Berrehal Ouala Eddine.";
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
            //MessageBox.Show("Cette fonctinalité n'est pas encore implementée!", "Action impossible");
            new Recuperer().Show();
        }

        private void add_ouvrage_Click(object sender, EventArgs e)
        {
            new ouvrage_add().Show();
        }

        private void ouvrages_list_Click(object sender, EventArgs e)
        {
            new Ouvrage_list().Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctinalité n'est pas encore implementée!", "Action impossible");
        }

        private void MenuView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}