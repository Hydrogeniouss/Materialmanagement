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
            AddRentedMaterials();
        }

        public void AddRentedMaterials()
        {
            sct_storage.Panel1.Controls.Clear();

            MemberHasRentedMaterial[] rents = MemberHasRentedMaterial.FromDatabase(true).ToArray();
            Dictionary<Material, Member> materialToMember = new();

            foreach (MemberHasRentedMaterial rent in rents)
            {
                materialToMember.Add(
                    Material.FromDatabase((int)rent.MaterialId!), Member.FromDatabase((int)rent.UserId!)
                    );
            }

            for (int i = 0; i < materialToMember.Count; i++)
            {
                RentedMaterialCardSmall rmcs = new RentedMaterialCardSmall(
                    materialToMember.Keys.ToArray()[i],
                    materialToMember.Values.ToArray()[i],
                    rents[i])
                {
                    Location = new Point(
                        RentedMaterialCardSmall.MARGIN,
                        i * (RentedMaterialCardSmall.STANDARDHEIGHT + RentedMaterialCardSmall.MARGIN) + RentedMaterialCardSmall.MARGIN
                    )
                };

                sct_storage.Panel1.Controls.Add(rmcs);

            }

        }
    }
}
