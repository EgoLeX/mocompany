using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOCompany
{
    public partial class loginscreen : Form
    {

        public loginscreen()
        {
            //Functions.propfiles.load(); // -------> remove this before publishing and it directly after one test to show it works
            
            InitializeComponent();
            ActiveControl = null;

            this.lbl_loginscreen_version.Text = Functions.data.version;
        }

        private void btn_loginscreen_close_Click(object sender, EventArgs e)
        {
            //Functions.propfiles.save();
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void llbl_loginscreen_needhelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://akegoprojects.webnode.com/mocompany/");
        }

        private void btn_loginscreen_login_Click(object sender, EventArgs e)
        {
            //login function
            if (!this.tb_loginscreen_name.Text.Equals(Properties.Settings.Default.usr_username) || !this.tb_loginscreen_ps.Text.Equals(Properties.Settings.Default.usr_password))
            {
                //logindata not correct
                MessageBox.Show("Login failed! Is the username and password correct?");
            }
            else if (this.rbtn_driveforyourowncompany.Checked == false && this.rbtn_loginscreen_driveforacompany.Checked == false) {
                //check if any gamemode choose
                MessageBox.Show("Please choose a gamemode first!");
            } else if (this.rbtn_driveforyourowncompany.Checked == true) {
                //check if own company profile exists
                if (Properties.Settings.Default.usr_comp_has == true)
                {
                    //company exists
                    using (Forms.owncompany_mainscreen ocscreen = new Forms.owncompany_mainscreen())
                    {
                        Hide();
                        ocscreen.ShowDialog();
                    }

                } else {
                    //no company exists
                    MessageBox.Show("You don't have any Company right now! You need to buy one in AIMode first!");
                }
            } else if (Functions.data.pathtoomsidir.Equals("")) {
                //if no omsidir selected, it has to be done now
                MessageBox.Show("OMSI2 Directory not set yet! Please select first the OMSI2 main directory!", "Select OMSI main directory ...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Controls.gl_settings gls = new Controls.gl_settings();
                gls.chooseOmsiDir();
            } else {
                using (Forms.aicompany_mainscreen aiboard = new Forms.aicompany_mainscreen()) {
                    Hide();
                    aiboard.ShowDialog();
                }
            }
        }
    }
}
