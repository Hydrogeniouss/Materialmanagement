using application.A_PL.Cards;
using application.B_BL;
using application.C_DAL;
using System.Data;

namespace application.A_PL
{
    public partial class MemberRentView : Form
    {
        public MemberRentView(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
        }

        private int _memberId = 0;

        private void RentView_Load(object sender, EventArgs e)
        {
            btn_borrow.Text = $"Ausleihen\n({DateTime.Now})";
            //TODO: Here, material brand Name and Type is switched :(

            try
            {
                AddMaterials(Material.FromDatabase());
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Material-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    RentView_Load(sender, e);
                }
                return;
            }

        }

        private void AddMaterials(List<Material> materials)
        {
            sct_rentMaterial.Panel1.Controls.Clear(); //apparently filtering via ofType<Card>() doesnt work, so full clear it is
            List<MaterialCardLarge> mclList = new(materials.Select(mat => new MaterialCardLarge(mat)));

            for (var i = 0; i < mclList.Count; i++)
            {
                Card mcl = mclList[i];
                mcl.Location = new Point(Card.MARGIN, (MaterialCardLarge.STANDARDHEIGHT + Card.MARGIN) * i + Card.MARGIN);
                if (mcl.BackColor == Card.STANDARDBACKCOLOR) mcl.Click += MaterialCard_Click;
                sct_rentMaterial.Panel1.Controls.Add(mcl);
            }
        }


        private void MaterialCard_Click(object? sender, EventArgs e)
        {
            if (sender is MaterialCardLarge mcl)
            {
                if (mcl.Parent == sct_rentMaterial.Panel1)
                {
                    if (mcl.BackColor == MaterialCardLarge.STANDARDBACKCOLOR)
                    {
                        mcl.BackColor = UIConfig.GREEN;
                        //TODO fix placements (buggy when scrolling starts working)
                        int itemsCount = sct_rentMaterial.Panel2.Controls.OfType<Card>().Count();
                        MaterialCardSmall mcs = new MaterialCardSmall(mcl)
                        {
                            Location = new Point(Card.MARGIN, (Card.STANDARDHEIGHT + Card.MARGIN) * itemsCount + Card.MARGIN)
                        };

                        mcs.Click += MaterialCard_Click;
                        mcs.btn_Delete.Click += MaterialCard_Click; //TODO: Doesnt Work, why??

                        sct_rentMaterial.Panel2.Controls.Add(mcs);

                        UpdateCards();
                    }

                    else
                    {
                        mcl.BackColor = MaterialCardLarge.STANDARDBACKCOLOR;

                        sct_rentMaterial.Panel2.Controls.Remove(
                            sct_rentMaterial.Panel2.Controls.OfType<MaterialCardSmall>().Where(
                                mcs => mcs.Origin == mcl).ToArray()[0]
                        );

                        UpdateCards();
                    }
                }

            }
            else if (sender is Button btn)
            {
                MaterialCardSmall mcs = (MaterialCardSmall)btn.Parent!;
                if (mcs.Parent == sct_rentMaterial.Panel2)
                {
                    mcs.Origin.BackColor = Color.LightGray;
                    mcs.Click -= MaterialCard_Click;
                    mcs.btn_Delete.Click -= MaterialCard_Click;
                    sct_rentMaterial.Panel2.Controls.Remove(mcs);

                    UpdateCards();
                }
            }
        }

        private void UpdateCards()
        {
            List<Card> cards = sct_rentMaterial.Panel1.Controls.OfType<Card>().ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                Card card = cards[i];
                card.Location = new Point(Card.MARGIN, (card.Height + Card.MARGIN) * i + Card.MARGIN);
            }

            cards = sct_rentMaterial.Panel2.Controls.OfType<Card>().ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                Card card = cards[i];
                card.Location = new Point(Card.MARGIN, (card.Height + Card.MARGIN) * i + Card.MARGIN);
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            MemberMaterialFilter filterView = new MemberMaterialFilter();
            filterView.ShowDialog();

            if (filterView.DialogResult == DialogResult.OK)
            {
                AddMaterials(filterView.Materials);
            }
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            // Loading Rent Data
            List<RentData> rents;
            try
            {
                rents = sct_rentMaterial.Panel2.Controls.OfType<MaterialCardSmall>()
                    .Select(mcs => new RentData((int)mcs.Amount.Value, DateTime.Now, null, _memberId, MaterialData.FromDatabase(new MaterialFilterData() { Name = mcs.lbl_Name.Text }).ToList()[0].Id)).ToList();
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Material-Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    btn_borrow_Click(sender, e);
                }
                return;
            }

            rents.ForEach(rent =>
            {
                MaterialData mat = MaterialData.FromDatabase(Convert.ToInt32(rent.MaterialId));
                mat.AmountAvailable -= rent.Quantity;

                try
                {
                    mat.UpdateOnDatabase();
                    rent.InsertIntoDatabase();
                }
                catch (Exception ex)
                {
                    if (DialogResult.Retry == MessageBox.Show("Material konnte nicht ausgeliehen werden, die Daten konnten nicht gespeichert werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                    {
                        btn_borrow_Click(sender, e);
                    }
                    return;
                }

            });
            sct_rentMaterial.Panel2.Controls.OfType<MaterialCardSmall>().ToList().ForEach(
            mat => mat.Origin.BackColor = MaterialCardSmall.STANDARDBACKCOLOR);
            UpdateCards();
            sct_rentMaterial.Panel2.Controls.Clear();
        }

        private void lbl_return_Click(object sender, EventArgs e)
        {
            new MemberReturnView(_memberId).Show();
            UiHelper.ProxyClose(this);
        }

        private void MemberRentView_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
