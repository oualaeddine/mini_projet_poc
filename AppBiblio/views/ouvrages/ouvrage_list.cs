using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppBiblio.api;
using OuveragesLib;

namespace AppBiblio.views.ouvrages
{
    public partial class Ouvrage_list : MetroFramework.Forms.MetroForm
    {
        public Ouvrage_list()
        {
            InitializeComponent();
        }

        public delegate void load_grid(LinkedList<Ouvrage> result);

        public void fillGrid(LinkedList<Ouvrage> result)
        {
            foreach (var ouvrage in result)
            {
                string isDispo;
                if (ouvrage.isDisponible)
                {
                    isDispo = "disponible";
                }
                else
                {
                    isDispo = "non disponible";
                }

                ouvrages_table.Rows.Add(
                    ouvrage.id,
                    ouvrage.title,
                    ouvrage.auteur,
                    ouvrage.theme,
                    ouvrage.n_mat,
                    isDispo,
                    ouvrage.keywords
                );
            }
        }

        private void Ouvrage_list_Load(object sender, EventArgs e)
        {
            loadData();
        }

        ContextMenuStrip menu;

        private void ouvrages_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu = new ContextMenuStrip();
                ouvrages_table.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    menu.Items.Add("Supprimer").Name = "supp";
                    menu.Items.Add("Modifier").Name = "edit";
                    if (ouvrages_table.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("disponible"))
                        menu.Items.Add("Preter").Name = "preter";
                    else
                        menu.Items.Add("Reserver").Name = "reserver";
                }

                Point pos = this.PointToClient(Cursor.Position);
                menu.Show(this, pos);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menu.Hide();
            switch (e.ClickedItem.Name.ToString())
            {
                case "supp":
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet ouvrage?",
                        "confirmation requise", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        delete_ouvrage(int.Parse(ouvrages_table.SelectedRows[0].Cells[0].Value.ToString()));
                    }

                    break;
                }
                case "edit":
                {
                    OuvrageEdited editedCallBack = edited;
                    new EditOuvrage(ouvrages_table.SelectedRows[0].Cells[0].Value, editedCallBack).Show();
                    break;
                }
                case "reserver":
                {
                    reserver(int.Parse(ouvrages_table.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                }
                case "preter":
                {
                    preter(int.Parse(ouvrages_table.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                }
            }
        }

        private void reserver(int id)
        {
            reserPret(id, false);
        }


        private void preter(int id)
        {
            reserPret(id, true);
        }

        private void reserPret(int id, bool isDispo)
        {
            OnOuvrageReserved ouvrageRes = onOuvrageReserved;
            //todo show reserver/preter view
        }

        void onOuvrageReserved(string action)
        {
            switch (action)
            {
                case "prete":
                {
                    MessageBox.Show("Prété avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                case "reserv":
                {
                    MessageBox.Show("reservation effectué avec succés!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                }
                case "error":
                {
                    showErrorBox();
                    break;
                }
            }
        }

        private void showErrorBox()
        {
            string ERROR = "Une erreur c'est produite!";

            MessageBox.Show(ERROR, "Erruer !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public delegate void OuvrageDeleted(bool isDeleted);

        public delegate void OnOuvrageReserved(string action);

        public delegate void OuvrageEdited(bool isEdited);


        public void edited(bool isEdited)
        {
            if (isEdited)
                MessageBox.Show("modifié avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                showErrorBox();

            ouvrages_table.Rows.Clear();
            loadData();
        }

        public void deleted(bool isDeleted)
        {
            if (isDeleted)
                MessageBox.Show("supprimé avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                showErrorBox();

            ouvrages_table.Rows.Clear();
            loadData();
        }

        private void loadData()
        {
            load_grid result = fillGrid;
            new OuvragesApi().getAll(result);
        }

        private void delete_ouvrage(int id)
        {
            OuvrageDeleted deleted = this.deleted;
            new OuvragesApi().delete(id, deleted);
        }

        private void trouver_Click(object sender, EventArgs e)
        {
            var search = searchBox.Text;
            load_grid result = fillGrid;
            new OuvragesApi().trouver(search, result);
        }
    }
}