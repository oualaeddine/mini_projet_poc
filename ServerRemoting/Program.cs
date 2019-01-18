using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using AuthLib;
using BiblioLib.work;
using HumansCRUD;
using OuvragesCRUD;

namespace ServerRemoting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel chnl = new TcpChannel(1234);
                ChannelServices.RegisterChannel(chnl, false);
                //pour lancer le serveur en mode Singleton,
                Console.WriteLine("Serveur démarré...");
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsersOperImpl), "biblioOper",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(MembersOperImpl), "membersOper",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ProfCRUD), "profsCRUD",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(StudentsCRUD), "studentsCRUD",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsersCRUD), "usersCRUD",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(OuvragesCRUDO), "ouvrageCRUD",
                    WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsersAuth), "usersAuth",
                    WellKnownObjectMode.Singleton);
                Console.WriteLine("Serveur démarré...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serveur:Erreur d'initialisation !" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}