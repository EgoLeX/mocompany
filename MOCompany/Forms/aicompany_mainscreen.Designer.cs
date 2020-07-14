namespace MOCompany.Forms
{
    partial class aicompany_mainscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aicompany_mainscreen));
            this.pl_aimode_navbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl_aimode_navbarcont = new System.Windows.Forms.Panel();
            this.btn_aimode_nav_company = new System.Windows.Forms.Button();
            this.btn_aimode_nav_bank = new System.Windows.Forms.Button();
            this.btn_aimode_nav_driverstatistic = new System.Windows.Forms.Button();
            this.btn_aimode_nav_drive = new System.Windows.Forms.Button();
            this.pl_aimode_navbar_profile = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_loginscreen_createdby = new System.Windows.Forms.Label();
            this.lbl_aimode_user_name = new System.Windows.Forms.Label();
            this.tt_aimode_ = new System.Windows.Forms.ToolTip(this.components);
            this.pl_aimode_main = new System.Windows.Forms.Panel();
            this.pb_aimode_nav_company = new System.Windows.Forms.PictureBox();
            this.pb_aimode_nav_bank = new System.Windows.Forms.PictureBox();
            this.pb_aimode_nav_driverstatistic = new System.Windows.Forms.PictureBox();
            this.pb_aimode_nav_drive = new System.Windows.Forms.PictureBox();
            this.btn_aimode_logout = new System.Windows.Forms.Button();
            this.btn_aimode_exit = new System.Windows.Forms.Button();
            this.btn_aimode_configureprofile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_aimode_navbar.SuspendLayout();
            this.pl_aimode_navbarcont.SuspendLayout();
            this.pl_aimode_navbar_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_driverstatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_drive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_aimode_navbar
            // 
            this.pl_aimode_navbar.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_aimode_navbar.Controls.Add(this.panel2);
            this.pl_aimode_navbar.Controls.Add(this.pl_aimode_navbarcont);
            this.pl_aimode_navbar.Controls.Add(this.btn_aimode_logout);
            this.pl_aimode_navbar.Controls.Add(this.btn_aimode_exit);
            this.pl_aimode_navbar.Controls.Add(this.pl_aimode_navbar_profile);
            resources.ApplyResources(this.pl_aimode_navbar, "pl_aimode_navbar");
            this.pl_aimode_navbar.Name = "pl_aimode_navbar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pl_aimode_navbarcont
            // 
            this.pl_aimode_navbarcont.Controls.Add(this.pb_aimode_nav_company);
            this.pl_aimode_navbarcont.Controls.Add(this.btn_aimode_nav_company);
            this.pl_aimode_navbarcont.Controls.Add(this.pb_aimode_nav_bank);
            this.pl_aimode_navbarcont.Controls.Add(this.btn_aimode_nav_bank);
            this.pl_aimode_navbarcont.Controls.Add(this.pb_aimode_nav_driverstatistic);
            this.pl_aimode_navbarcont.Controls.Add(this.btn_aimode_nav_driverstatistic);
            this.pl_aimode_navbarcont.Controls.Add(this.pb_aimode_nav_drive);
            this.pl_aimode_navbarcont.Controls.Add(this.btn_aimode_nav_drive);
            resources.ApplyResources(this.pl_aimode_navbarcont, "pl_aimode_navbarcont");
            this.pl_aimode_navbarcont.Name = "pl_aimode_navbarcont";
            // 
            // btn_aimode_nav_company
            // 
            resources.ApplyResources(this.btn_aimode_nav_company, "btn_aimode_nav_company");
            this.btn_aimode_nav_company.FlatAppearance.BorderSize = 0;
            this.btn_aimode_nav_company.ForeColor = System.Drawing.Color.White;
            this.btn_aimode_nav_company.Name = "btn_aimode_nav_company";
            this.tt_aimode_.SetToolTip(this.btn_aimode_nav_company, resources.GetString("btn_aimode_nav_company.ToolTip"));
            this.btn_aimode_nav_company.UseVisualStyleBackColor = true;
            this.btn_aimode_nav_company.Click += new System.EventHandler(this.btn_aimode_nav_company_Click);
            // 
            // btn_aimode_nav_bank
            // 
            resources.ApplyResources(this.btn_aimode_nav_bank, "btn_aimode_nav_bank");
            this.btn_aimode_nav_bank.FlatAppearance.BorderSize = 0;
            this.btn_aimode_nav_bank.ForeColor = System.Drawing.Color.White;
            this.btn_aimode_nav_bank.Name = "btn_aimode_nav_bank";
            this.tt_aimode_.SetToolTip(this.btn_aimode_nav_bank, resources.GetString("btn_aimode_nav_bank.ToolTip"));
            this.btn_aimode_nav_bank.UseVisualStyleBackColor = true;
            this.btn_aimode_nav_bank.Click += new System.EventHandler(this.btn_aimode_nav_bank_Click);
            // 
            // btn_aimode_nav_driverstatistic
            // 
            resources.ApplyResources(this.btn_aimode_nav_driverstatistic, "btn_aimode_nav_driverstatistic");
            this.btn_aimode_nav_driverstatistic.FlatAppearance.BorderSize = 0;
            this.btn_aimode_nav_driverstatistic.ForeColor = System.Drawing.Color.White;
            this.btn_aimode_nav_driverstatistic.Name = "btn_aimode_nav_driverstatistic";
            this.tt_aimode_.SetToolTip(this.btn_aimode_nav_driverstatistic, resources.GetString("btn_aimode_nav_driverstatistic.ToolTip"));
            this.btn_aimode_nav_driverstatistic.UseVisualStyleBackColor = true;
            this.btn_aimode_nav_driverstatistic.Click += new System.EventHandler(this.btn_aimode_nav_driverstatistic_Click);
            // 
            // btn_aimode_nav_drive
            // 
            resources.ApplyResources(this.btn_aimode_nav_drive, "btn_aimode_nav_drive");
            this.btn_aimode_nav_drive.FlatAppearance.BorderSize = 0;
            this.btn_aimode_nav_drive.ForeColor = System.Drawing.Color.White;
            this.btn_aimode_nav_drive.Name = "btn_aimode_nav_drive";
            this.tt_aimode_.SetToolTip(this.btn_aimode_nav_drive, resources.GetString("btn_aimode_nav_drive.ToolTip"));
            this.btn_aimode_nav_drive.UseVisualStyleBackColor = true;
            this.btn_aimode_nav_drive.Click += new System.EventHandler(this.btn_aimode_nav_drive_Click);
            // 
            // pl_aimode_navbar_profile
            // 
            this.pl_aimode_navbar_profile.Controls.Add(this.panel1);
            this.pl_aimode_navbar_profile.Controls.Add(this.lbl_loginscreen_createdby);
            this.pl_aimode_navbar_profile.Controls.Add(this.btn_aimode_configureprofile);
            this.pl_aimode_navbar_profile.Controls.Add(this.lbl_aimode_user_name);
            this.pl_aimode_navbar_profile.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pl_aimode_navbar_profile, "pl_aimode_navbar_profile");
            this.pl_aimode_navbar_profile.Name = "pl_aimode_navbar_profile";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Name = "panel1";
            // 
            // lbl_loginscreen_createdby
            // 
            resources.ApplyResources(this.lbl_loginscreen_createdby, "lbl_loginscreen_createdby");
            this.lbl_loginscreen_createdby.ForeColor = System.Drawing.Color.White;
            this.lbl_loginscreen_createdby.Name = "lbl_loginscreen_createdby";
            // 
            // lbl_aimode_user_name
            // 
            resources.ApplyResources(this.lbl_aimode_user_name, "lbl_aimode_user_name");
            this.lbl_aimode_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_aimode_user_name.Name = "lbl_aimode_user_name";
            // 
            // pl_aimode_main
            // 
            resources.ApplyResources(this.pl_aimode_main, "pl_aimode_main");
            this.pl_aimode_main.Name = "pl_aimode_main";
            // 
            // pb_aimode_nav_company
            // 
            this.pb_aimode_nav_company.BackgroundImage = global::MOCompany.Properties.Resources.ico_addbusiness_materialio;
            resources.ApplyResources(this.pb_aimode_nav_company, "pb_aimode_nav_company");
            this.pb_aimode_nav_company.Name = "pb_aimode_nav_company";
            this.pb_aimode_nav_company.TabStop = false;
            // 
            // pb_aimode_nav_bank
            // 
            this.pb_aimode_nav_bank.BackgroundImage = global::MOCompany.Properties.Resources.ico_account_balance_materialio;
            resources.ApplyResources(this.pb_aimode_nav_bank, "pb_aimode_nav_bank");
            this.pb_aimode_nav_bank.Name = "pb_aimode_nav_bank";
            this.pb_aimode_nav_bank.TabStop = false;
            // 
            // pb_aimode_nav_driverstatistic
            // 
            this.pb_aimode_nav_driverstatistic.BackgroundImage = global::MOCompany.Properties.Resources.ico_statistic_materialio;
            resources.ApplyResources(this.pb_aimode_nav_driverstatistic, "pb_aimode_nav_driverstatistic");
            this.pb_aimode_nav_driverstatistic.ErrorImage = global::MOCompany.Properties.Resources.ico_statistic_materialio;
            this.pb_aimode_nav_driverstatistic.Name = "pb_aimode_nav_driverstatistic";
            this.pb_aimode_nav_driverstatistic.TabStop = false;
            // 
            // pb_aimode_nav_drive
            // 
            this.pb_aimode_nav_drive.BackgroundImage = global::MOCompany.Properties.Resources.ico_bus_materialio;
            resources.ApplyResources(this.pb_aimode_nav_drive, "pb_aimode_nav_drive");
            this.pb_aimode_nav_drive.Name = "pb_aimode_nav_drive";
            this.pb_aimode_nav_drive.TabStop = false;
            // 
            // btn_aimode_logout
            // 
            this.btn_aimode_logout.BackgroundImage = global::MOCompany.Properties.Resources.ico_logoutlogin_materialio;
            resources.ApplyResources(this.btn_aimode_logout, "btn_aimode_logout");
            this.btn_aimode_logout.FlatAppearance.BorderSize = 0;
            this.btn_aimode_logout.Name = "btn_aimode_logout";
            this.tt_aimode_.SetToolTip(this.btn_aimode_logout, resources.GetString("btn_aimode_logout.ToolTip"));
            this.btn_aimode_logout.UseVisualStyleBackColor = true;
            this.btn_aimode_logout.Click += new System.EventHandler(this.btn_aimode_logout_Click);
            // 
            // btn_aimode_exit
            // 
            this.btn_aimode_exit.BackgroundImage = global::MOCompany.Properties.Resources.ico_close_materialio;
            resources.ApplyResources(this.btn_aimode_exit, "btn_aimode_exit");
            this.btn_aimode_exit.FlatAppearance.BorderSize = 0;
            this.btn_aimode_exit.Name = "btn_aimode_exit";
            this.tt_aimode_.SetToolTip(this.btn_aimode_exit, resources.GetString("btn_aimode_exit.ToolTip"));
            this.btn_aimode_exit.UseVisualStyleBackColor = true;
            this.btn_aimode_exit.Click += new System.EventHandler(this.btn_aimode_exit_Click);
            // 
            // btn_aimode_configureprofile
            // 
            resources.ApplyResources(this.btn_aimode_configureprofile, "btn_aimode_configureprofile");
            this.btn_aimode_configureprofile.BackgroundImage = global::MOCompany.Properties.Resources.ico_tune_sett_materialio;
            this.btn_aimode_configureprofile.FlatAppearance.BorderSize = 0;
            this.btn_aimode_configureprofile.Name = "btn_aimode_configureprofile";
            this.tt_aimode_.SetToolTip(this.btn_aimode_configureprofile, resources.GetString("btn_aimode_configureprofile.ToolTip"));
            this.btn_aimode_configureprofile.UseVisualStyleBackColor = true;
            this.btn_aimode_configureprofile.Click += new System.EventHandler(this.btn_aimode_configureprofile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MOCompany.Properties.Resources.ico_employeecard_materialio;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // aicompany_mainscreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.pl_aimode_main);
            this.Controls.Add(this.pl_aimode_navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aicompany_mainscreen";
            this.pl_aimode_navbar.ResumeLayout(false);
            this.pl_aimode_navbarcont.ResumeLayout(false);
            this.pl_aimode_navbar_profile.ResumeLayout(false);
            this.pl_aimode_navbar_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_driverstatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aimode_nav_drive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_aimode_navbar;
        private System.Windows.Forms.Panel pl_aimode_navbar_profile;
        private System.Windows.Forms.Button btn_aimode_configureprofile;
        private System.Windows.Forms.Label lbl_aimode_user_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_loginscreen_createdby;
        private System.Windows.Forms.Button btn_aimode_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip tt_aimode_;
        private System.Windows.Forms.Button btn_aimode_logout;
        private System.Windows.Forms.Panel pl_aimode_navbarcont;
        private System.Windows.Forms.Button btn_aimode_nav_drive;
        private System.Windows.Forms.PictureBox pb_aimode_nav_driverstatistic;
        private System.Windows.Forms.Button btn_aimode_nav_driverstatistic;
        private System.Windows.Forms.PictureBox pb_aimode_nav_drive;
        private System.Windows.Forms.PictureBox pb_aimode_nav_bank;
        private System.Windows.Forms.Button btn_aimode_nav_bank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_aimode_main;
        private System.Windows.Forms.PictureBox pb_aimode_nav_company;
        private System.Windows.Forms.Button btn_aimode_nav_company;
    }
}