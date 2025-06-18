using application.B_BL;
using application.C_DAL;
using System.Drawing;

namespace application.A_PL
{
    public partial class MemberMaterialFilter : Form
    {
        public List<Material> Materials = new();
        public MemberMaterialFilter()
        {
            InitializeComponent();
        }

        private void MaterialFilter_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_brand.Items.AddRange(C_DAL.BrandData.FromDatabase().ToArray());
                cbx_type.Items.AddRange(C_DAL.TypeData.FromDatabase().ToArray());
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Filter konnte nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    MaterialFilter_Load(sender, e);
                }
                return;
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Materials = B_BL.Material.FromDatabase(new MaterialFilterData()
                {
                    Name = tbx_name.Text.Trim().Length > 0 ? tbx_name.Text.Trim() : null,
                    Description = tbx_description.Text.Trim().Length > 0 ? tbx_description.Text.Trim() : null,
                    Brand = cbx_brand.SelectedItem as TypeData,
                    Type = cbx_type.SelectedItem as TypeData,
                });
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Materialien konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    btn_submit_Click(sender, e);
                }
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
