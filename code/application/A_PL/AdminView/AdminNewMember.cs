using application.B_BL;
using System.Drawing;
namespace application.A_PL.AdminView
{
    public partial class AdminNewMember : Form
    {
        public AdminNewMember()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool isAllFilled = true;
            int isInt = 0;

            foreach (var tbx in Controls.OfType<TextBox>().ToList())
            {
                if (tbx.Text == "" || tbx.Text == null)
                    isAllFilled = false;
            }

            if (!isAllFilled)
                MessageBox.Show("Es müssen alle felder ausgefüllt sein.");

            else if (!rad_admin.Checked && !rad_member.Checked)
                MessageBox.Show("Es muss AdministratorIn oder Mitglied ausgewählt werfen");

            else if (rad_member.Checked && !int.TryParse(tbx_passKey.Text, out isInt))
                MessageBox.Show("Ein PIN für Mitglieder muss ein vierstelliger Zahlencode sein.");

            else if (rad_member.Checked && (isInt > 9999 || isInt < 1000)) // > 9999 and < 1000 because PIN must be exactly 4 Numbers
                MessageBox.Show("Ein PIN für Mitglieder muss vierstellig sein sein");

            else
            {
                try
                {
                    if (rad_admin.Checked)
                        new Admin(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, tbx_passKey.Text)
                            .InsertIntoDatabase();
                    else
                        new Member(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, Convert.ToInt32(tbx_passKey.Text))
                            .InsertIntoDatabase();
                }
                catch (Exception ex)
                {
                    if (DialogResult.Retry == MessageBox.Show("Daten konnten nicht Gespeichert werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                    {
                        btn_save_Click(sender, e);
                    }
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
