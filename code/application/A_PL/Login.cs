using application.B_BL;

namespace application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is a test to see if the database connection works
            // and if the data is being pulled correctly
            var materials = Member.FromDatabase();
            MessageBox.Show($"There are {materials.Count} materials in the database.");
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Member mem = Member.FromDatabase().Where(mem => mem.FirstName == tbx_firstName.Text
                    && mem.LastName == tbx_lastName.Text).ToArray()[0];

                if (mem.Pin.ToString() == tbx_pin.Text.Trim()) 
                {
                    

                }
            }
            catch
            {
                lbl_errorMessage.Text = "Der Vor- oder Nachname oder der PIN ist Falsch.";
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
