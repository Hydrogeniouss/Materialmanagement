using System.Data;


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
                B_BL.Admin admin = B_BL.Admin.FromDatabase().Where(admin => admin.FirstName == tbx_firstName.Text //TODO: Why does using not work?
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
