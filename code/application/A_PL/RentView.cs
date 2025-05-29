using application.B_BL;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace application.A_PL
{
    public partial class RentView : Form
    {
        public RentView()
        {
            InitializeComponent();
        }

        private void RentView_Load(object sender, EventArgs e)
        {
            btn_borrow.Text = $"Ausleihen\n({DateTime.Now})";
            //TODO: Here, material brand Name and Type is switched :(
            AddMaterials(Material.FromDatabase());

        }
        private void AddMaterials(List<Material> materials)
        {
            sct_rentMaterial.Panel1.Controls.Clear(); //apparently filtering via ofType<Card>() doesnt work, so full clear it is
            List<MaterialCardLarge> mclList = new(materials.Select(mat => new MaterialCardLarge(mat.Name, mat.Brand.Name, mat.Description, null)));

            for (var i = 0; i < mclList.Count; i++)
            {
                Card mcl = mclList[i];
                mcl.Location = new Point(Card.MARGIN, (mcl.Height + Card.MARGIN) * i + Card.MARGIN);
                mcl.Click += MaterialCard_Click;
                sct_rentMaterial.Panel1.Controls.Add(mcl);
            }
        }


        private void MaterialCard_Click(object? sender, EventArgs e)
        {
            if (sender is MaterialCardLarge mcl)
            {
                if (mcl.Parent == sct_rentMaterial.Panel1)
                {
                    if (mcl.BackColor != Color.MediumPurple)
                    {
                        mcl.BackColor = Color.MediumPurple;

                        //TODO fix placements (buggy when scrolling starts working)
                        int itemsCount = sct_rentMaterial.Panel2.Controls.OfType<Card>().Count();
                        MaterialCardSmall mcs = new MaterialCardSmall(mcl)
                        {
                            Location = new Point(Card.MARGIN, (Card.STANDARDHEIGHT + Card.MARGIN) * itemsCount + Card.MARGIN)
                        };

                        mcs.Click += MaterialCard_Click;
                        mcs.btn_Delete.Click += MaterialCard_Click; //TODO: Doesnt Work, why??

                        sct_rentMaterial.Panel2.Controls.Add(mcs);
                    }

                    else
                    {
                        mcl.BackColor = Color.RebeccaPurple;

                        sct_rentMaterial.Panel2.Controls.Remove(
                            sct_rentMaterial.Panel2.Controls.OfType<MaterialCardSmall>().Where(
                                mcs => mcs.Origin == mcl).ToArray()[0]
                        );

                        UpdateCards();
                    }
                }

            }
            else if (sender is MaterialCardSmall mcs)
            {
                if (mcs.Parent == sct_rentMaterial.Panel2)
                {
                    mcs.Origin.BackColor = Color.RebeccaPurple;
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
            var filterView = new MaterialFilter();
            filterView.ShowDialog();
            if (filterView.DialogResult == DialogResult.OK)
            {
                AddMaterials(filterView.materials);
            }
        }
    }
}
