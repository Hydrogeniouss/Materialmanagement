using application.B_BL;
using application.C_DAL;
using System.Data;

namespace application.A_PL
{
    public partial class MaterialFilter : Form
    {
        internal List<Material> materials = new();
        public MaterialFilter()
        {
            InitializeComponent();
        }

        private void MaterialFilter_Load(object sender, EventArgs e)
        {
            cbx_brand.Items.AddRange(C_DAL.BrandData.FromDatabase().ToArray());
            cbx_type.Items.AddRange(C_DAL.TypeData.FromDatabase().ToArray());
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            materials = B_BL.Material.FromDatabase(new MaterialFilterData()
            {
                Name = tbx_name.Text.Trim().Length > 0 ? tbx_name.Text.Trim() : null,
                Description = tbx_description.Text.Trim().Length > 0 ? tbx_description.Text.Trim() : null,
                Brand = cbx_brand.SelectedItem as BrandData,
                Type = cbx_type.SelectedItem as TypeData,
            });
            DialogResult = DialogResult.OK;
        }
    }
}
