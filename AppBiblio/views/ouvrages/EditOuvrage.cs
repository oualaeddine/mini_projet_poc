using System;
using System.Windows.Forms;

namespace AppBiblio.views.ouvrages
{
    public partial class EditOuvrage : Form
    {
        private Ouvrage_list.OuvrageEdited editedCallBack;
        private object value;

        public EditOuvrage(object value, Ouvrage_list.OuvrageEdited editedCallBack)
        {
            this.value = value;
            this.editedCallBack = editedCallBack;
            InitializeComponent();
        }


        private void EditOuvrage_Load(object sender, EventArgs e)
        {
        }
    }
}