using System.Collections.Generic;
using AppBiblio.views.ouvrages;
using OuveragesLib;

namespace AppBiblio.api
{
    public class OuvragesApi
    {
        public void add(Ouvrage ouvrage)
        {
            // throw new System.NotImplementedException();
            //todo addOuvrageApi
        }

        public void delete(int id, Ouvrage_list.OuvrageDeleted deleted)
        {
            deleted(true);
        }

        public void reserver(int id, int idMember, object reserved)
        {
        }

        public void rendre(string id, object rendu /*todo*/)
        {
        }

        public void trouver(string search, Ouvrage_list.load_grid ouvragesApiCallBack)
        {
        }

        public void getAll(Ouvrage_list.load_grid ouvragesApiCallBack)
        {
            var ouvrages = new LinkedList<Ouvrage>();
            ouvrages.AddLast(new Ouvrage

            {
                auteur = "Ouala eddine",
                id = 1,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = true
            });
            ouvrages.AddLast(new Ouvrage
            {
                auteur = "Ouala Eddine",
                id = 2,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = false
            });
            ouvrages.AddLast(new Ouvrage
            {
                auteur = "Ouala Eddine",
                id = 3,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = false
            });
            ouvragesApiCallBack(ouvrages);
        }
    }
}