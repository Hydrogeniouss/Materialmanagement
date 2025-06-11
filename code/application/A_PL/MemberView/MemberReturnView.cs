namespace application.A_PL
{
    public partial class MemberReturnView : Form
    {
        public MemberReturnView()
        {
            InitializeComponent();
        }

        private void ReturnView_Load(object sender, EventArgs e)
        {
            btn_return.Text = $"Zurückgeben\n({DateTime.Now})";
        }
    }
}
