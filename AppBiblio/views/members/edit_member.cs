using System.Windows.Forms;

namespace AppBiblio.views.members
{
    public partial class edit_member : Form
    {
        private members_list.OnMemberEdited onMemberEdited;
        private object value;

        public edit_member()
        {
            InitializeComponent();
        }

        public edit_member(object value) : this()
        {
            this.value = value;
        }

        public edit_member(object value, members_list.OnMemberEdited onMemberEdited) : this(value)
        {
            this.onMemberEdited = onMemberEdited;
        }
    }
}