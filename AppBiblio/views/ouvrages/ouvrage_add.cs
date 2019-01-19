using System;
using System.Windows.Forms;
using AppBiblio.api;
using OuveragesLib;

namespace AppBiblio.views
{
    public partial class ouvrage_add : MetroFramework.Forms.MetroForm
    {
        public ouvrage_add()
        {
            InitializeComponent();
        }

        private void ouvrage_add_Load(object sender, EventArgs e)
        {
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string title = title_tb.Text;
            string auteur = auteur_tb.Text;
            string numero = n_mat_tb.Text;
            string theme = theme_cb.Text;
            string keywords = key_words_tb.Text;

            var ouvrage = new Ouvrage
            {
                title = title,
                auteur = auteur,
                n_mat = numero,
                theme = theme,
                keywords = keywords
            };

            if (true)
            {
                new OuvragesApi().add(ouvrage);
                MessageBox.Show("Ouvrage correctement ajouté", "Operation reussite!");
                Hide();
            }
            else
            {
                MessageBox.Show("verifiez les informations que vous avez entré", "Impossible d'ajouter l'ouvrage");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}