using AppBiblio.views;
using AuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Windows.Forms;

namespace AppBiblio.api
{
    class AuthApi
    {

        public string ip = "127.0.0.1";
        public int port = 1234;
        private UsersAuth autUser;

        public AuthApi()
        {
            try
            {
                var chnls = ChannelServices.RegisteredChannels;
                foreach (var chnl in chnls)
                {
                    ChannelServices.UnregisterChannel(chnl);
                }

                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);

                Console.WriteLine("Client: Canal enregistré");


                autUser = (UsersAuth)Activator.GetObject(
                    typeof(UsersAuth),
                    "tcp://" + ip + ":" + port + "/usersAuth");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR :" + ex.Message);
            }
        }

        public void login(string email, string password, Login.OnLoginCallBack callback)
        {
            var human = new HumansLib.User { email = email };
            callback(autUser.login(human, password));
        }


    }
}
