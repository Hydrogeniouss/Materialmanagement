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
            AddMaterials(Material.FromDatabase());
        }
        private void AddMaterials(List<Material> materials)
        {
            sct_rentMaterial.Panel1.Controls.OfType<MaterialCard>().ToList().Clear();
            List<MaterialCard> cards = new(materials.Select(mat => new MaterialCard(mat.Name, mat.Brand.Name, mat.Description, null)));

            for (var i = 0; i < cards.Count; i++)
            {
                MaterialCard card = cards[i];
                card.Location = new Point(card.Margin, (card.Height + card.Margin) * i + 100);
                card.Click += Card_Click;
                sct_rentMaterial.Panel1.Controls.Add(card);
            }
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender is MaterialCard card)
            {
                if (card.Parent == sct_rentMaterial.Panel1)
                {
                    int itemsCount = sct_rentMaterial.Panel2.Controls.OfType<MaterialCard>().Count();
                    card.Location = new Point(card.Margin, (card.Height + card.Margin) * itemsCount + 100);
                    

                    sct_rentMaterial.Panel2.Controls.Add(card);
                    UpdateCards();
                }

                else if (card.Parent == sct_rentMaterial.Panel2)
                {
                    int itemsCount = sct_rentMaterial.Panel1.Controls.Count;
                    card.Location = new Point(card.Margin, (card.Height + card.Margin) * itemsCount + 100);

                    sct_rentMaterial.Panel1.Controls.Add(card);
                    UpdateCards();
                }
            }
        }

        private void UpdateCards()
        {   
            List<MaterialCard> cards = sct_rentMaterial.Panel1.Controls.OfType<MaterialCard>().ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                MaterialCard card = cards[i];
                card.Location = new Point(card.Margin, (card.Height + card.Margin) * i + 100);
            }

            cards = sct_rentMaterial.Panel2.Controls.OfType<MaterialCard>().ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                MaterialCard card = cards[i];
                card.Location = new Point(card.Margin, (card.Height + card.Margin) * i + 100);
            }
        }

        private void btn_discard_Click(object sender, EventArgs e)
        {

        }
    }
}
