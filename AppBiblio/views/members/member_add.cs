using AppBiblio.api;
using HumansLib;
using HumansLib.profs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppBiblio.views
{
    public partial class member_add : MetroFramework.Forms.MetroForm
    {
        public member_add()
        {
            InitializeComponent();
        }

        private void member_add_Load(object sender, EventArgs e)
        {

        }

        private void add_b_Click(object sender, EventArgs e)
        {
            string nom = this.nom.Text;
            string prenom = this.prenom.Text;
            string date = this.date.Text;
            string sexe = "homme";
            if (homme.Checked)
                sexe = "homme";
            if (femme.Checked)
                sexe = "femme";
            string tel = this.tel.Text;
            string email = this.email.Text;
            string adresse = this.adresse.Text;
            string password = genererMdp();



            var api = new membersApi();
            if (etud.Checked)
            {
                string n_carte = this.nom.Text;
                string niveau = this.nom.Text;

                var etudiant = new Student();
                etudiant.nom = nom;
                etudiant.prenom = prenom;
                etudiant.dateNaissance = DateTime.Parse(date);
                etudiant.sexe = sexe;
                etudiant.telephone = tel;
                etudiant.email = email;
                etudiant.adresse = adresse;
                etudiant.n_carte = n_carte;
                etudiant.niveau = niveau;
                etudiant.password = password;

                api.addMember(etudiant);
            }
            if (prof.Checked)
            {
                string matricule = this.nom.Text;

                var prof = new Prof();

                prof.nom = nom;
                prof.prenom = prenom;
                prof.dateNaissance = DateTime.Parse(date);
                prof.sexe = sexe;
                prof.telephone = tel;
                prof.email = email;
                prof.adresse = adresse;
                prof.matricule = matricule;
                prof.password = password;

                api.addMember(prof);
            }

            MessageBox.Show("votre mot de passe : " + password);
            this.Close();
        }

        private string genererMdp()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void etud_CheckedChanged(object sender, EventArgs e)
        {
            if (etud.Checked)
                tabs.SelectedIndex = 0;
        }

        private void prof_CheckedChanged(object sender, EventArgs e)
        {
            if (prof.Checked)
                tabs.SelectedIndex = 1;
        }
    }
}
