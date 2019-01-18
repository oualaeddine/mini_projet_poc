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

        public void getAll(Ouvrage_list.load_grid ouvragesApiCallBack)
        {
            var ouvrages = new LinkedList<Ouvrage>();
            ouvrages.AddLast(new Ouvrage

            {
                auteur = "",
                id = 1,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = "disponnible"
            });
            ouvrages.AddLast(new Ouvrage
            {
                auteur = "",
                id = 2,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = "non disponnible"
            });
            ouvrages.AddLast(new Ouvrage
            {
                auteur = "",
                id = 3,
                keywords = "keyword",
                n_mat = "gkrjgrkgj524",
                theme = "theme",
                title = "title",
                isDisponible = "non disponnible"
            });
            ouvragesApiCallBack(ouvrages);
        }
    }


    public interface OuvragesApiCallBack
    {
        void resultat(LinkedList<Ouvrage> resultat);
    }
}