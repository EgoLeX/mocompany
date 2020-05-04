using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCompany.Forms
{
    public partial class owncompany_mainscreen : Form
    {
        public owncompany_mainscreen()
        {
            InitializeComponent();
            ActiveControl = null;
            onLoad();
        }

        private void onLoad()
        {
            //load bg image
            if(Functions.data.companytype == 1)
            {
                this.BackgroundImage = Properties.Resources._c01_bgscreen;
            } else if (Functions.data.companytype == 2)
            {
                this.BackgroundImage = Properties.Resources._c02_bgscreen;
            }
            else if (Functions.data.companytype == 3)
            {
                this.BackgroundImage = Properties.Resources._c03_bgscreen;
            }
            //set username on navbar
            lbl_owncompany_username.Text = Functions.data.usrname;
        }

        //method to get panel where control have to go in
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pl_ownmode_main.Controls.Clear();
            pl_ownmode_main.Controls.Add(c); //add Controlpanel
        }

        //exit
        private void btn_ownmode_exit_Click(object sender, EventArgs e)
        {
            Functions.propfiles.save();
            Application.Exit();
        }

        //logout
        private void btn_ownmode_logout_Click(object sender, EventArgs e)
        {
            using (loginscreen ls = new loginscreen())
            {
                Hide();
                ls.ShowDialog();
            }
        }

        //donate
        private void btn_donatepaypal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mocompany-omsiaddon.webnode.com/download/");
        }

        private void btn_ownmode_configureprofile_Click(object sender, EventArgs e)
        {
            Controls.gl_settings gls = new Controls.gl_settings();
            addControlsToPanel(gls);
        }

        private void btn_ownmode_nav_drive_Click(object sender, EventArgs e)
        {
            Controls.gl_drive gdrive = new Controls.gl_drive();
            addControlsToPanel(gdrive);
        }

        private void btn_ownmode_nav_company_Click(object sender, EventArgs e)
        {
            Controls.gl_companymarket gcomarket = new Controls.gl_companymarket();
            addControlsToPanel(gcomarket);
        }

        private void btn_ownmode_nav_bank_Click(object sender, EventArgs e)
        {
            Controls.own_bankacc owbacc = new Controls.own_bankacc();
            addControlsToPanel(owbacc);
        }

        private void btn_ownmode_nav_oepnvstore_Click(object sender, EventArgs e)
        {
            Controls.own_vehstore ovstore = new Controls.own_vehstore();
            addControlsToPanel(ovstore);
        }

        private void btn_ownmode_nav_management_Click(object sender, EventArgs e)
        {
            Controls.own_managment management = new Controls.own_managment();
            addControlsToPanel(management);
        }
    }
}
