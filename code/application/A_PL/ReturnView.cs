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
    public partial class ReturnView : Form
    {
        public ReturnView()
        {
            InitializeComponent();
        }

        private void ReturnView_Load(object sender, EventArgs e)
        {
            btn_return.Text = $"Zurückgeben\n({DateTime.Now})";
        }
    }
}
