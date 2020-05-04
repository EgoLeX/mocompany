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
    public partial class aicompany_mainscreen : Form
    {
        public aicompany_mainscreen()
        {
            InitializeComponent();
            ActiveControl = null;
            lbl_aimode_user_name.Text = Functions.data.usrname;
        }

        //method to get panel where control have to go in
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pl_aimode_main.Controls.Clear();
            pl_aimode_main.Controls.Add(c); //add Controlpanel
        }

        private void btn_aimode_exit_Click(object sender, EventArgs e)
        {
            Functions.propfiles.save();
            Application.Exit();
        }

        private void btn_aimode_logout_Click(object sender, EventArgs e)
        {
            using (loginscreen ls = new loginscreen() )
            {
                Functions.propfiles.save();
                Hide();
                ls.ShowDialog();
            }
        }

        private void btn_aimode_nav_bank_Click(object sender, EventArgs e)
        {
            Controls.ai_bankacc bankpg = new Controls.ai_bankacc();
            addControlsToPanel(bankpg);
        }

        private void btn_aimode_nav_drive_Click(object sender, EventArgs e)
        {
            Controls.gl_drive gdrive = new Controls.gl_drive();
            addControlsToPanel(gdrive);
           
        }

        private void btn_aimode_nav_company_Click(object sender, EventArgs e)
        {
            Controls.gl_companymarket comarket = new Controls.gl_companymarket();
            addControlsToPanel(comarket);
        }

        private void btn_aimode_configureprofile_Click(object sender, EventArgs e)
        {
            Controls.gl_settings gls = new Controls.gl_settings();
            addControlsToPanel(gls);
        }

        private void btn_donatepaypal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mocompany-omsiaddon.webnode.com/download/");
        }

        private void btn_aimode_nav_driverstatistic_Click(object sender, EventArgs e)
        {
            Controls.gl_driverdata dridata = new Controls.gl_driverdata();
            addControlsToPanel(dridata);
        }
    }
}
