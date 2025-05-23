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
    }
}
