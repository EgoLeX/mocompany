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
    public partial class own_vehstore : UserControl
    {
        public own_vehstore()
        {
            InitializeComponent();
            onLoad();
        }

        private void onLoad()
        {
            Controls.own_vehstore_busses ovb = new Controls.own_vehstore_busses();
            addControlsToPanel(ovb);
        }

        //method to get panel where control have to go in
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pl_opnvstore_main.Controls.Clear();
            pl_opnvstore_main.Controls.Add(c); //add Controlpanel
        }

        private void lbox_vehtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_vehtype.GetItemText(lbox_vehtype.SelectedItem).Equals("Bus"))
            {
                Controls.own_vehstore_busses ovb = new Controls.own_vehstore_busses();
                addControlsToPanel(ovb);
            }
            else if (lbox_vehtype.GetItemText(lbox_vehtype.SelectedItem).Equals("Tram"))
            {
                Controls.own_vehstore_tram ovt = new Controls.own_vehstore_tram();
                addControlsToPanel(ovt);
            }
        }
    }
}
