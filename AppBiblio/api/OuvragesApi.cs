using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using AppBiblio.views.oper;
using AppBiblio.views.ouvrages;
using BiblioLib;
using OuveragesLib;
using OuvragesCRUD;

namespace AppBiblio.api
{
    public class OuvragesApi
    {
        public OuvragesApi()
        {
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");

                ouvrageCRUD = (IOuvrageDAO) Activator.GetObject(
                    typeof(IOuvrageDAO),
                    "tcp://" + ip + ":" + port + "/profsCRUD");


                userOper = (IUsersOper) Activator.GetObject(
                    typeof(IOuvrageDAO),
                    "tcp://" + ip + ":" + port + "/biblioOper");

                memberOper = (IMembersOper) Activator.GetObject(
                    typeof(IOuvrageDAO),
                    "tcp://" + ip + ":" + port + "/membersOper");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR :" + ex.Message);
            }
        }

        public string port { get; set; }

        public string ip { get; set; }

        public IMembersOper memberOper { get; set; }

        public IUsersOper userOper { get; set; }

        public IOuvrageDAO ouvrageCRUD { get; set; }

        public void add(Ouvrage ouvrage)
        {
            ouvrageCRUD.insert(ouvrage);
        }

        public void delete(int id, Ouvrage_list.OuvrageDeleted deleted)
        {
            deleted(ouvrageCRUD.delete(id));
        }

        public void reserver(int id, int idMember, ReserverPreter.OnOuvrageReserve reserved)
        {
            memberOper.reserver(idMember, id);
        }

        public void rendre(string id, Recuperer.OnOuvrageRendu rendu)
        {
            rendu(userOper.recuperer(new Ouvrage {id = int.Parse(id)}));
        }

        public void trouver(string search, Ouvrage_list.load_grid ouvragesApiCallBack)
        {
            ouvragesApiCallBack(ouvrageCRUD.find(search));
        }

        public void getAll(Ouvrage_list.load_grid ouvragesApiCallBack)
        {
            ouvragesApiCallBack(ouvrageCRUD.getAll());
        }

        public void trouverById(int idOuvrage, ReserverPreter.OnOuvrageFound ouvrageFound)
        {
            ouvrageFound(ouvrageCRUD.getById(idOuvrage));
        }

        public void preter(int idOuvrage, int idMembreRes, ReserverPreter.OnOuvragePrete prete)
        {
            prete(userOper.preter(idOuvrage, idMembreRes));
        }
    }
}