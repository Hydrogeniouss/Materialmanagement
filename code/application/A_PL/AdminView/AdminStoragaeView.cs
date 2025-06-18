using application.A_PL.AdminView;
using application.A_PL.Cards;
using application.B_BL;
using System.Data;


namespace application.A_PL
{
    public partial class AdminStoragaeView : Form
    {
        public AdminStoragaeView()
        {
            InitializeComponent();
            AddRentCards();
            AddRentHistoryCards();
        }

        /// <summary>
        /// Adds RentCards (All rented Materials) to the according Panel (sct_storage.Panel1.Controls)
        /// </summary>
        public void AddRentCards()
        {
            sct_storage.Panel1.Controls.Clear();

            // loading all rents and ordering by date of aquisition
            Rent[] rents;
            try
            {
                rents = Rent.FromDatabase(true).ToArray();
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Ausleih-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    AddRentCards();
                }
                return;
            }

            // loading all Materials and Members, belonging to the rents
            Dictionary<Material, Member> materialToMember = new();
            try
            {
                foreach (Rent rent in rents)
                {
                    materialToMember.Add(
                        Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                    );
                }
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Mitglieder/Material-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    AddRentCards();
                }
                return;
            }

            for (int i = 0; i < materialToMember.Count; i++)
            {
                RentCard rentCard = new RentCard(rents[i])
                {
                    Location = new Point(
                        RentCard.MARGIN,
                        i * (RentCard.STANDARDHEIGHT + RentCard.MARGIN) + RentCard.MARGIN
                    )
                };

                sct_storage.Panel1.Controls.Add(rentCard);

            }

        }

        /// <summary>
        /// Adds RentHistoryCards (All LoanHistory Entries) to the according Panel (sct_storage.Panel2.Controls)
        /// </summary>
        public void AddRentHistoryCards()
        {
            sct_storage.Panel2.Controls.Clear();

            // loading all rents and ordering by date of aquisition
            Rent[] rents;
            try
            {
                rents = Rent.FromDatabase(false).OrderByDescending(x => x.DateOfAquisition).ToArray();
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Ausleih-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    AddRentHistoryCards();
                }
                return;
            }

            Dictionary<Material, Member> materialToMember = new();
            // Adding Material and Member over N to M relation of rent
            try
            {
                foreach (Rent rent in rents)
                {
                    materialToMember.Add(
                        Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                    );
                }
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Mitglieder/Material-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    AddRentCards();
                }
                return;
            }

            // Adding Rents to the rent history Panel
            for (int i = 0; i < materialToMember.Count; i++)
            {
                // Vars for defining y Location
                int yLocation = 0;
                Rent rent = rents[i];

                if (i > 0)
                {
                    yLocation = sct_storage.Panel2.Controls.OfType<RentHistoryCard>().ToArray()[i - 1].Bottom;

                    if (rent.DateOfAquisition.Date != rents[i - 1].DateOfAquisition.Date)
                    {
                        yLocation += RentHistoryCard.MARGIN;
                    }
                }

                RentHistoryCard rmcs = new RentHistoryCard(
                    materialToMember.Keys.ToArray()[i],
                    materialToMember.Values.ToArray()[i],
                    rents[i])
                {
                    Location = new Point(
                        RentHistoryCard.MARGIN,
                        yLocation
                    )
                };

                sct_storage.Panel2.Controls.Add(rmcs);

            }

        }

        private void AdminStoragaeView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lbl_members_Click(object sender, EventArgs e)
        {
            new AdminMemberView().Show();
            Close();
        }
    }
}
