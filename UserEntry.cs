using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ATC
{
    public partial class UserEntry : Form
    {
        public UserEntry()
        {
            InitializeComponent();
        }

        private bool Is_SignIn_Not_SignUp = true;

        String AccHoldPath = @"C:\Users\HP\source\repos\ATC\Account Holders.txt";                     // File Path where Account Details are Stored

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Is_SignIn_Not_SignUp = false;

            labelChooseAction.Visible = false;

            btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Lime;

            panelRole_Passcode.Visible = true;
            userControlEnter1.Visible = true;
            btnEnter.Visible = true;
            btnExit.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Is_SignIn_Not_SignUp = true;

            labelChooseAction.Visible = false;

            btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;

            panelRole_Passcode.Visible = false;
            userControlEnter1.Visible = true;
            btnEnter.Visible = true;
            btnExit.Visible = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(Is_SignIn_Not_SignUp)
            {
                if (Login_Account())
                {
                    this.Close();
                    //new MainForm().Show();
                }

                else MessageBox.Show("INVALID CREDENTIALS !", "Access Privilege Not Granted", MessageBoxButtons.OK);
            }

            else
            {
                if (!Create_Account(txtRolePasscode.Text) || txtRolePasscode.TextLength == 0)
                {
                    MessageBox.Show("INVALID CREDENTIALS !", "Access Privilege Not Granted", MessageBoxButtons.OK);
                }
                else
                {
                    this.Close();
                    //new MainForm().Show();
                }
            }
        }


        public bool Create_Account(String RPC)
        {
            Account_Holder_Data AHD = new Account_Holder_Data();
            AHD.SetData(userControlEnter1.Gettext(), userControlEnter1.Gettext(2), userControlEnter1.SelectedData.Data, RPC);

            if (AHD.isValidPasscode())
            {

                StreamWriter writer = File.AppendText(AccHoldPath);
                writer.WriteLine(AHD.Get_CSV_Data());
                writer.Close();

                return true;
            }

            return false;
        }

        public bool Login_Account()//String HE, String Pwrd, String role)
        {
            //FileInfo Acc_File = new FileInfo(@"C:\Users\HP\source\repos\ATC\Account Holders.txt");
            //if (!Acc_File.Exists) Acc_File.Create();
            StreamReader reader = File.OpenText(AccHoldPath);

            while (!reader.EndOfStream)
            {
                char[] Separator = { ',' };
                String[] Data = reader.ReadLine().Split(Separator, 4, StringSplitOptions.RemoveEmptyEntries);

                if (userControlEnter1.Gettext() == Data[0] && userControlEnter1.Gettext(2) == Data[1] && userControlEnter1.SelectedData.Data == Data[2]) return true;
            }

            reader.Close();
            return false;
        }


        public class Account_Holder_Data                                              // To Wriite Account Holder Details into a File
        {
            private String Handle_Email, Password;
            private String Role, Role_Passcode;

            public void SetData(String HE, String Pwd, String Ro, String RP) { Handle_Email = HE; Password = Pwd; Role = Ro; Role_Passcode = RP; }
            public String Get_CSV_Data() { return Handle_Email + "," + Password + "," + Role + "," + Role_Passcode; }

            private static Dictionary<String, String> Passcodes = new Dictionary<string, string>() { { "Administrator", "#ATC#@*Admin*" }, { "User", "User@ATC#" } }; // This can be Modified/Set during SETUP

            public bool isValidPasscode() { return Role_Passcode == Passcodes[Role]; }

        }
    }
}
