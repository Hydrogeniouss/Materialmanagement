using application.B_BL;


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
            Admin admin;
            try
            {
                admin = Admin.FromDatabase(tbx_firstName.Text, tbx_lastName.Text);
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder das Passwort ist Falsch.\n" +
                    "Möglicherweise hat die Verbindung zur Datenbank Fehlgesschlagen";
                return;
            }

            if (admin.Password.ToString() == tbx_password.Text.Trim())
            {
                new AdminStoragaeView().Show();
                Close();
            }
            else
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder das Passwort ist Falsch.";
            }

        }

        private void btn_loginMember_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void LoginAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!UiHelper.ProgramaticallyClosing)
            {
                UiHelper.ProxyExit();
            }
            else
            {
                UiHelper.ProgramaticallyClosing = false; // Reset for next use
            }

        }
    }
}
