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
                card.Location = new Point(10, 200*i + 100);
                sct_rentMaterial.Panel1.Controls.Add(card);
            }
        }
    }
}
