using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class UserControlEnter : UserControl
    {
        public UserControlEnter()
        {
            InitializeComponent();
        }

        public CBOoptions SelectedData { get { return (CBOoptions)cboRoles.SelectedItem; } }

        public String Gettext(int option=1) 
        {
            return option == 1 ? txtHandle_Email.Text.ToString() : txtPassword.Text.ToString();
        }

        private void UserControlEnter_Load(object sender, EventArgs e)
        {
            List<CBOoptions> URlist = new List<CBOoptions>();

            URlist.Add(new CBOoptions("User"));
            URlist.Add(new CBOoptions("Administrator"));

            cboRoles.DisplayMember = "Data";
            cboRoles.ValueMember = "ID";
            cboRoles.DataSource = URlist;
        }
    }
}
