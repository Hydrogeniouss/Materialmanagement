namespace application.A_PL;

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
        UiHelper.ProxyClose(this);
    }


    /* Preset for try catch for database access @marnie
            try
            {
                //DB Access
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    // Method call for the method this code is in itself
                }
                return;
            }
    */
}

