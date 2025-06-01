using application.B_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.A_PL
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {

            InitializeComponent();
            
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = Admin.FromDatabase().Where(admin => admin.FirstName == tbx_firstName.Text
                    && admin.LastName == tbx_lastName.Text).ToArray()[0];

                if (admin.Password.ToString() == tbx_password.Text.Trim())
                {
                    new AdminStoragaeVeiw().Show();
                    Close();
                }
                else
                {
                    lbl_errorMessage.Text = "Der Vor- oder Nachname oder das Passwort ist Falsch.";
                }
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder das Passwort ist Falsch.\n" +
                    "Möglicherweise hat die Verbindung zur Datenbank Fehlgesschlagen";
            }


        }

        private void btn_loginMember_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }
    }
}
