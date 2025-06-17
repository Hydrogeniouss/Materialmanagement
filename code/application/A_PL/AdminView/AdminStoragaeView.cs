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
            Rent[] rents = Rent.FromDatabase(true).ToArray();
            Dictionary<Material, Member> materialToMember = new();

            foreach (Rent rent in rents)
            {
                materialToMember.Add(
                    Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                );
            }

            for (int i = 0; i < materialToMember.Count; i++)
            {
                RentCard rentCard = new RentCard(
                    materialToMember.Keys.ToArray()[i],
                    materialToMember.Values.ToArray()[i],
                    rents[i])
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
            Rent[] rents = Rent.FromDatabase().OrderByDescending(x => x.DateOfAquisition).ToArray();
            Dictionary<Material, Member> materialToMember = new();

            // Adding Material and Member over N to M relation of rent
            foreach (Rent rent in rents)
            {
                materialToMember.Add(
                    Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                );
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

        private void lbl_material_Click(object sender, EventArgs e)
        {
            new AdminMemberView().Show();
            Close();
        }

        private void AdminStoragaeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}
