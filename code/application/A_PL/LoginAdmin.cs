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
                Member mem = Member.FromDatabase().Where(mem => mem.FirstName == tbx_firstName.Text
                    && mem.LastName == tbx_lastName.Text).ToArray()[0];

                if (mem.Pin.ToString() == tbx_pin.Text.Trim())
                {
                    new RentView().Show();
                    Close();
                }
                else
                {
                    lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.";
                }
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.";
            }


        }

        private void btn_loginMember_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }
    }
}
