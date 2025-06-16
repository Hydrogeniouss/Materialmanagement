using application.B_BL;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace application.A_PL
{
    public partial class MemberReturnView : Form
    {
        public MemberReturnView(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
        }

        private int _memberId;


        public int MemId { get; set; }

        private void ReturnView_Load(object sender, EventArgs e)
        {
            btn_return.Text = $"Zurückgeben\n({DateTime.Now})";
        }

        private void lbl_borrow_Click(object sender, EventArgs e)
        {
            new MemberRentView(_memberId).Show();
            Close();
        }
    }
}
