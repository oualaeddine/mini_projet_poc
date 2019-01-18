using System;
using System.Windows.Forms;
using AppBiblio.api;

namespace AppBiblio.views.oper
{
    public partial class Recuperer : MetroFramework.Forms.MetroForm
    {
        public Recuperer()
        {
            InitializeComponent();
        }

        private void Recuperer_Load(object sender, EventArgs e)
        {
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public delegate void OnOuvrageRendu(bool isRendu);

        public void onOuvrageRendu(bool isRendu)
        {
            if (isRendu)
            {
                MessageBox.Show("Rendu avec succés");
                Hide();
            }
            else
            {
                MessageBox.Show("Erreur! Ouvrage non rendu!");
            }
        }

        private void recuperer_btn_Click(object sender, EventArgs e)
        {
            var mat = matricule.Text;
            if (mat.Length > 0)
            {
                OnOuvrageRendu rendu = onOuvrageRendu;
                new OuvragesApi().rendre(mat, rendu);
            }
            else
            {
                MessageBox.Show("veuillez introduire le matricule de l'ouvrage");
            }
        }
    }
}