using AppBiblio.api;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }
        public delegate void OnLoginCallBack(bool boolean);
        private void loginRes(bool res)
        {
         

            if (res)
            {

                new MenuView().Show();
                this.Hide();

            }
            else
            {
               
                MessageBox.Show("erreur de connection! ");
                
            }

        }
        private void connect_btn_Click(object sender, EventArgs e)
        {
            OnLoginCallBack loginResult = loginRes;

            if (email.Text.Length > 5 && password.Text.Length > 4)
            {
                new AuthApi().login(email.Text, password.Text, loginResult);

               
            }

        }

        private void annuler_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
