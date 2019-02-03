using System;
using System.Windows.Forms;
using AppBiblio.api;
using HumansLib;
using OuveragesLib;

namespace AppBiblio.views.ouvrages
{
    public partial class ReserverPreter : MetroFramework.Forms.MetroForm
    {
        private Ouvrage_list.OnOuvrageReserved ouvrageRes;

        public ReserverPreter(int id, bool isDispo, Ouvrage_list.OnOuvrageReserved ouvrageRes)
        {
            this.idOuvrage = id;
            this.isOuvrageDispo = isDispo;
            this.ouvragesApi = new OuvragesApi();
            this.ouvrageRes = ouvrageRes;
            InitializeComponent();
        }

        public OuvragesApi ouvragesApi { get; set; }

        public bool isOuvrageDispo { get; set; }

        public int idOuvrage { get; set; }


        public delegate void OnOuvrageFound(Ouvrage ouvrage);

        private void ReserverPreter_Load(object sender, EventArgs e)
        {
            OnOuvrageFound ouvrageFound = onOuvrageFound;
            ouvragesApi.trouverById(idOuvrage, ouvrageFound);
        }

        private void onOuvrageFound(Ouvrage ouvrage)
        {
            titre.Text = "Titre : " + ouvrage.title;
            matricule.Text = "Matricule : " + ouvrage.n_mat;
            theme.Text = "Theme : " + ouvrage.theme;
            auteur.Text = "Auteur : " + ouvrage.auteur;
        }


        public delegate void OnMemberFound(Human human, bool isSuspended);

        private void find_btn_Click(object sender, EventArgs e)
        {
            var search = search_box.Text;
            if (search.Length > 0)
            {
                OnMemberFound found = onMemeberFound;
                new membersApi().trouverMembre(search, found);
            }
            else
            {
                MessageBox.Show("Veillez remplir le champ de recherche");
            }
        }

        private void onMemeberFound(Human human, bool isSuspended)
        {
            if (human == null)
            {
                MessageBox.Show("aucun memebre n'a été trouvé");
            }
            else
            {
                nom_membre.Text = "Nom : " + human.nom;
                Prenom_membre.Text = "Prenom : " + human.prenom;
                id_membre.Text = "Id Membre : " + human.id;
                etat_membre.Text = "Etat : " + (isSuspended ? "suspendu" : "non suspendu");
                this.idMembreRes = human.id;

                this.isOuvrageDispo= new OuvragesApi().isOuvrageDispoForUser(idOuvrage,human.id);
            }
        }

        public int idMembreRes { get; set; }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public delegate void OnOuvragePrete(bool isPrete);

        public delegate void OnOuvrageReserve(bool isReserved);


        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (isOuvrageDispo)
            {
                OnOuvragePrete prete = onOuvragePrete;
                ouvragesApi.preter(idOuvrage, idMembreRes, prete);
            }
            else
            {
                OnOuvrageReserve reserve = onOuvrageRes;
                ouvragesApi.reserver(idOuvrage, idMembreRes, reserve);
            }
        }

        private void onOuvrageRes(bool isreserved)
        {
            Hide();

            this.ouvrageRes((isreserved ? "reserv" : "error"));
        }

        private void onOuvragePrete(bool isprete)
        {
            Hide();
            this.ouvrageRes((isprete ? "prete" : "error"));
        }
    }
}