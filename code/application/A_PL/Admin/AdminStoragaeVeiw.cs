using application.A_PL.Cards;
using application.B_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.A_PL
{
    public partial class AdminStoragaeVeiw : Form
    {
        public AdminStoragaeVeiw()
        {
            InitializeComponent();
            AddRentCards();
            AddRentHistoryCards();
        }

        public void AddRentCards()
        {
            sct_storage.Panel1.Controls.Clear();

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
                RentCard rmcs = new RentCard(
                    materialToMember.Keys.ToArray()[i],
                    materialToMember.Values.ToArray()[i],
                    rents[i])
                {
                    Location = new Point(
                        RentCard.MARGIN,
                        i * (RentCard.STANDARDHEIGHT + RentCard.MARGIN) + RentCard.MARGIN
                    )
                };

                sct_storage.Panel1.Controls.Add(rmcs);

            }

        }

        public void AddRentHistoryCards()
        {
            sct_storage.Panel2.Controls.Clear();

            Rent[] rents = Rent.FromDatabase().ToArray();
            Dictionary<Material, Member> materialToMember = new();

            // Adding Material and Member over n to m relation of rent
            foreach (Rent rent in rents)
            {
                materialToMember.Add(
                    Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                    );
            }

            for (int i = 0; i < materialToMember.Count; i++)
            {
                RentHistoryCard rmcs = new RentHistoryCard(
                    materialToMember.Keys.ToArray()[i],
                    materialToMember.Values.ToArray()[i],
                    rents[i])
                {
                    Location = new Point(
                        RentHistoryCard.MARGIN,
                        i * (RentHistoryCard.STANDARDHEIGHT + RentHistoryCard.MARGIN) + RentHistoryCard.MARGIN
                    )
                };

                sct_storage.Panel2.Controls.Add(rmcs);

            }

        }
    }
}
