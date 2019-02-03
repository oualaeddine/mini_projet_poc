using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AppBiblio.api;
using HumansLib;
using HumansLib.profs;

namespace AppBiblio.views.members
{
    public partial class members_list : MetroFramework.Forms.MetroForm
    {
        public members_list()
        {
            InitializeComponent();
        }

        private void members_list_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        ContextMenuStrip menu;

        private void members_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu = new ContextMenuStrip();
                members_table.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    menu.Items.Add("Supprimer").Name = "supp";
                    menu.Items.Add("Modifier").Name = "edit";
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
                    DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce membre?",
                        "confirmation requise", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        delete_member(int.Parse(members_table.SelectedRows[0].Cells[0].Value.ToString()),
                            members_table.SelectedRows[0].Cells[3].Value.ToString());
                        MessageBox.Show("supprimé avec succés!");
                    }

                    break;
                }
                case "edit":
                {
                    OnMemberEdited onMemberEdited = edited;
                    new edit_member(members_table.SelectedRows[0].Cells[0].Value, onMemberEdited);
                    break;
                }
            }
        }

        private void delete_member(int value, string type)
        {
            OnMemberDeleted onMemberDeleted = deleted;
            new membersApi().delete(value, type, onMemberDeleted);
        }

        public delegate void OnMemberDeleted(bool isDeleted);

        public delegate void OnMemberEdited(bool isEdited);

        public delegate void OnGetData(LinkedList<Human> result);

        void fillGrid(LinkedList<Human> result)
        {
            foreach (var human in result)
            {
                if (human.GetType() == typeof(Prof))
                {
                    var prof = (Prof) human;
                    members_table.Rows.Add(
                        prof.id,
                        prof.nom,
                        prof.prenom,
                        "Enseignant",
                        prof.telephone,
                        prof.email,
                        prof.matricule,
                        prof.sexe,
                        "",
                        "",
                        prof.dateNaissance,
                        prof.adresse
                    );
                }
                else
                {
                    var student = (Student) human;
                    members_table.Rows.Add(
                        student.id,
                        student.nom,
                        student.prenom,
                        "Etudiant",
                        student.telephone,
                        student.email,
                        "",
                        student.sexe,
                        student.n_carte,
                        student.niveau,
                        student.dateNaissance,
                        student.adresse
                    );
                }
            }
        }

        private const string ERROR = "Une erreur c'est produite!";

        private void deleted(bool isDeleted)
        {
            if (isDeleted)
                MessageBox.Show("supprimé avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(ERROR, "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            load_grid();
        }

        private void edited(bool isEdited)
        {
            if (isEdited)
                MessageBox.Show("modifié avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(ERROR, "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            load_grid();
        }

        private void load_grid()
        {
            OnGetData result = fillGrid;
            new membersApi().getAll(result);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OnGetData result = fillGrid;
            members_table.Rows.Clear();
            new membersApi().trouverMembre(metroTextBox1.Text,result);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}