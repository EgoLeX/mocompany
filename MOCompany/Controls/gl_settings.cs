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
    public partial class gl_settings : UserControl
    {
        public gl_settings()
        {
            InitializeComponent();
            this.tb_settings_user_username.Text = Functions.data.usrname;
            this.tb_settings_user_passw.Text = Functions.data.password;
            this.tb_settings_general_pathtoomsidir.Text = Functions.data.pathtoomsidir;

            if (Functions.data.usrhascompany == true) {
                lb_settings_user_hascompcheck.Text = "Yes"+" - "+Functions.data.companytype;
            } else {
                lb_settings_user_hascompcheck.Text = "No";
            }
        }

        public void tb_settings_general_pathtoomsidir_Click(object sender, EventArgs e)
        {
            chooseOmsiDir();
        }

        private void btn_settings_save_Click(object sender, EventArgs e)
        {
            //save all settings in data file (its necessary to accept first all changes)
            if (MessageBox.Show("Are you sure you want to save? \n(Info: Some changes need a restart!)", "Confirm saving ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                Functions.data.usrname = tb_settings_user_username.Text;
                Functions.data.password = tb_settings_user_passw.Text;
                Functions.data.pathtoomsidir = tb_settings_general_pathtoomsidir.Text;

                //save all global
                Functions.propfiles.save();
            }
            else
            {
                // user clicked no
            }
        }

        private void urlInBrowser(String aurl)
        {
            System.Diagnostics.Process.Start(aurl);
        }

        private void llb_settings_credit_kartoffelphantom_Click(object sender, EventArgs e)
        {
            urlInBrowser("https://reboot.omsi-webdisk.de/net/user/2240-kartoffelphantom/");
        }

        private void pl_settings_headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llbl_settings_credit_jockie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            urlInBrowser("https://reboot.omsi-webdisk.de/net/user/7191-jockie/");
        }

        public void chooseOmsiDir()
        {
            DialogResult objResult = fbd_settings.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                if (fbd_settings.SelectedPath.Contains("OMSI"))
                {
                    Functions.data.pathtoomsidir = fbd_settings.SelectedPath;

                    if (tb_settings_general_pathtoomsidir.Text.Equals(""))
                    {
                        tb_settings_general_pathtoomsidir.Text = fbd_settings.SelectedPath;
                    }

                }
                else
                {
                    MessageBox.Show("OMSI Directory not selected!", "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
