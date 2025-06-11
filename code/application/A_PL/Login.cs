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
            try
            {
                Member mem = Member.FromDatabase().Where(mem => mem.FirstName == tbx_firstName.Text
                    && mem.LastName == tbx_lastName.Text).ToArray()[0];

                if (mem.Pin.ToString() == tbx_pin.Text.Trim())
                {
                    new MemberRentView((int)mem.Id).Show();
                    this.Close();
                }
                else
                {
                    lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.";
                }
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.\n" +
                    "Möglicherweise hat die Verbindung zur Datenbank Fehlgesschlagen";
            }

        }

        private void btn_loginAsAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdmin().Show();
            Close();
        }
    }
}
