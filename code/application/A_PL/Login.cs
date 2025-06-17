using application.A_PL;
using application.B_BL;

namespace application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Member mem;
            try
            {
                mem = Member.FromDatabase(tbx_firstName.Text, tbx_lastName.Text);
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.\n" +
                    "Möglicherweise hat die Verbindung zur Datenbank Fehlgesschlagen";

                return;
            }

            if (mem.Pin.ToString() == tbx_pin.Text.Trim())
            {
                new MemberRentView((int)mem.Id!).Show();
                Close();
            }
            else
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.";
            }
        }

        private void btn_loginAsAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            Close();
        }
    }
}
