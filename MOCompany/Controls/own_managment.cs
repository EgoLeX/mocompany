using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCompany.Controls
{
    public partial class own_managment : UserControl
    {
        public own_managment()
        {
            InitializeComponent();
            onLoadManagmentPage();
        }

        private void onLoadManagmentPage()
        {
            if (lb_managment_compname.Text.Equals("")){ lb_managment_compname.Text = "MOC.DUMMYCOMPANYNAME"; } else { lb_managment_compname.Text = Functions.data.companyname; } 
        }

        private void btn_managment_nav_carpool_Click(object sender, EventArgs e)
        {

        }
    }
}
