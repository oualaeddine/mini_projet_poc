using System;
using System.Drawing;
using System.Windows.Forms;
using AppBiblio.api;

namespace AppBiblio.views
{
    public partial class members_list : MetroFramework.Forms.MetroForm
    {
        public members_list()
        {
            InitializeComponent();
        }

        private void members_list_Load(object sender, EventArgs e)
        {
            members_table.Rows.Add(1, "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add(2, "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add(3, "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add(4, "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
            members_table.Rows.Add("1", "XX", "XX", "Etudiant", "XX", "XX", "Homme", "XX", "XX", "XX", "XX");
        }

        ContextMenuStrip menu;

        private void members_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu = new ContextMenuStrip();
                int position_xy_mouse_row = members_table.HitTest(e.X, e.Y).RowIndex;
                //  members_table.SelectedRows.Clear();
                members_table.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    menu.Items.Add("Supprimer").Name = "supp";
                    menu.Items.Add("Modifier").Name = "edit";
                }

                //   menu.Show(members_table, e.Location);
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
                        //do something
                        delete_member(int.Parse(members_table.SelectedRows[0].Cells[0].Value.ToString()));
                        MessageBox.Show("supprimé avec succés!");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                    break;
                }
                case "edit":
                {
                    //todo show edit memeber window 
                    //    new EditMember(members_table.SelectedRows[0].Cells[0].Value);
                    break;
                }
            }
        }

        private void delete_member(int value)
        {
            new membersApi().delete(value);
            this.Refresh();
        }
    }
}