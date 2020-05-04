namespace MOCompany.Controls
{
    partial class gl_settings
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gl_settings));
            this.pl_settings_headerpanel = new System.Windows.Forms.Panel();
            this.pl_settings_header_pgtitel = new System.Windows.Forms.Panel();
            this.lb_settings_titleheader = new System.Windows.Forms.Label();
            this.btn_settings_save = new System.Windows.Forms.Button();
            this.pl_settings_leftdock = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_settings_nav_generaltitel = new System.Windows.Forms.Label();
            this.lb_settings_nav_usrtitel = new System.Windows.Forms.Label();
            this.pl_settings_usersettings = new System.Windows.Forms.Panel();
            this.lb_settings_user_hascompcheck = new System.Windows.Forms.Label();
            this.lb_settings_user_hascompanytitle = new System.Windows.Forms.Label();
            this.tb_settings_user_passw = new System.Windows.Forms.TextBox();
            this.lb_settings_user_usrpwdtitel = new System.Windows.Forms.Label();
            this.tb_settings_user_username = new System.Windows.Forms.TextBox();
            this.lb_settings_user_usrname_titel = new System.Windows.Forms.Label();
            this.pl_settings_generalsettings = new System.Windows.Forms.Panel();
            this.tb_settings_general_pathtoomsidir = new System.Windows.Forms.TextBox();
            this.lb_settings_general_pathtoomsidir = new System.Windows.Forms.Label();
            this.fbd_settings = new System.Windows.Forms.FolderBrowserDialog();
            this.tt_settings = new System.Windows.Forms.ToolTip(this.components);
            this.pl_settings_credits = new System.Windows.Forms.Panel();
            this.llbl_settings_credit_jockie = new System.Windows.Forms.LinkLabel();
            this.llb_settings_credit_kartoffelphantom = new System.Windows.Forms.LinkLabel();
            this.lb_settings_credits_message = new System.Windows.Forms.Label();
            this.lb_settings_credits_title = new System.Windows.Forms.Label();
            this.pb_settings_generalsettings = new System.Windows.Forms.PictureBox();
            this.pb_settings_usersettings = new System.Windows.Forms.PictureBox();
            this.pl_settings_headerpanel.SuspendLayout();
            this.pl_settings_header_pgtitel.SuspendLayout();
            this.pl_settings_leftdock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pl_settings_usersettings.SuspendLayout();
            this.pl_settings_generalsettings.SuspendLayout();
            this.pl_settings_credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings_generalsettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings_usersettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_settings_headerpanel
            // 
            resources.ApplyResources(this.pl_settings_headerpanel, "pl_settings_headerpanel");
            this.pl_settings_headerpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_settings_headerpanel.Controls.Add(this.pl_settings_header_pgtitel);
            this.pl_settings_headerpanel.Name = "pl_settings_headerpanel";
            this.tt_settings.SetToolTip(this.pl_settings_headerpanel, resources.GetString("pl_settings_headerpanel.ToolTip"));
            this.pl_settings_headerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_settings_headerpanel_Paint);
            // 
            // pl_settings_header_pgtitel
            // 
            resources.ApplyResources(this.pl_settings_header_pgtitel, "pl_settings_header_pgtitel");
            this.pl_settings_header_pgtitel.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_settings_header_pgtitel.Controls.Add(this.lb_settings_titleheader);
            this.pl_settings_header_pgtitel.Name = "pl_settings_header_pgtitel";
            this.tt_settings.SetToolTip(this.pl_settings_header_pgtitel, resources.GetString("pl_settings_header_pgtitel.ToolTip"));
            // 
            // lb_settings_titleheader
            // 
            resources.ApplyResources(this.lb_settings_titleheader, "lb_settings_titleheader");
            this.lb_settings_titleheader.ForeColor = System.Drawing.Color.White;
            this.lb_settings_titleheader.Name = "lb_settings_titleheader";
            this.tt_settings.SetToolTip(this.lb_settings_titleheader, resources.GetString("lb_settings_titleheader.ToolTip"));
            // 
            // btn_settings_save
            // 
            resources.ApplyResources(this.btn_settings_save, "btn_settings_save");
            this.btn_settings_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_settings_save.FlatAppearance.BorderSize = 0;
            this.btn_settings_save.ForeColor = System.Drawing.Color.White;
            this.btn_settings_save.Name = "btn_settings_save";
            this.tt_settings.SetToolTip(this.btn_settings_save, resources.GetString("btn_settings_save.ToolTip"));
            this.btn_settings_save.UseVisualStyleBackColor = false;
            this.btn_settings_save.Click += new System.EventHandler(this.btn_settings_save_Click);
            // 
            // pl_settings_leftdock
            // 
            resources.ApplyResources(this.pl_settings_leftdock, "pl_settings_leftdock");
            this.pl_settings_leftdock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_settings_leftdock.Controls.Add(this.panel1);
            this.pl_settings_leftdock.Name = "pl_settings_leftdock";
            this.tt_settings.SetToolTip(this.pl_settings_leftdock, resources.GetString("pl_settings_leftdock.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lb_settings_nav_generaltitel);
            this.panel1.Controls.Add(this.pb_settings_generalsettings);
            this.panel1.Controls.Add(this.lb_settings_nav_usrtitel);
            this.panel1.Controls.Add(this.pb_settings_usersettings);
            this.panel1.Name = "panel1";
            this.tt_settings.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // lb_settings_nav_generaltitel
            // 
            resources.ApplyResources(this.lb_settings_nav_generaltitel, "lb_settings_nav_generaltitel");
            this.lb_settings_nav_generaltitel.ForeColor = System.Drawing.Color.White;
            this.lb_settings_nav_generaltitel.Name = "lb_settings_nav_generaltitel";
            this.tt_settings.SetToolTip(this.lb_settings_nav_generaltitel, resources.GetString("lb_settings_nav_generaltitel.ToolTip"));
            // 
            // lb_settings_nav_usrtitel
            // 
            resources.ApplyResources(this.lb_settings_nav_usrtitel, "lb_settings_nav_usrtitel");
            this.lb_settings_nav_usrtitel.ForeColor = System.Drawing.Color.White;
            this.lb_settings_nav_usrtitel.Name = "lb_settings_nav_usrtitel";
            this.tt_settings.SetToolTip(this.lb_settings_nav_usrtitel, resources.GetString("lb_settings_nav_usrtitel.ToolTip"));
            // 
            // pl_settings_usersettings
            // 
            resources.ApplyResources(this.pl_settings_usersettings, "pl_settings_usersettings");
            this.pl_settings_usersettings.Controls.Add(this.lb_settings_user_hascompcheck);
            this.pl_settings_usersettings.Controls.Add(this.lb_settings_user_hascompanytitle);
            this.pl_settings_usersettings.Controls.Add(this.tb_settings_user_passw);
            this.pl_settings_usersettings.Controls.Add(this.lb_settings_user_usrpwdtitel);
            this.pl_settings_usersettings.Controls.Add(this.tb_settings_user_username);
            this.pl_settings_usersettings.Controls.Add(this.lb_settings_user_usrname_titel);
            this.pl_settings_usersettings.Name = "pl_settings_usersettings";
            this.tt_settings.SetToolTip(this.pl_settings_usersettings, resources.GetString("pl_settings_usersettings.ToolTip"));
            // 
            // lb_settings_user_hascompcheck
            // 
            resources.ApplyResources(this.lb_settings_user_hascompcheck, "lb_settings_user_hascompcheck");
            this.lb_settings_user_hascompcheck.ForeColor = System.Drawing.Color.Black;
            this.lb_settings_user_hascompcheck.Name = "lb_settings_user_hascompcheck";
            this.tt_settings.SetToolTip(this.lb_settings_user_hascompcheck, resources.GetString("lb_settings_user_hascompcheck.ToolTip"));
            // 
            // lb_settings_user_hascompanytitle
            // 
            resources.ApplyResources(this.lb_settings_user_hascompanytitle, "lb_settings_user_hascompanytitle");
            this.lb_settings_user_hascompanytitle.Name = "lb_settings_user_hascompanytitle";
            this.tt_settings.SetToolTip(this.lb_settings_user_hascompanytitle, resources.GetString("lb_settings_user_hascompanytitle.ToolTip"));
            // 
            // tb_settings_user_passw
            // 
            resources.ApplyResources(this.tb_settings_user_passw, "tb_settings_user_passw");
            this.tb_settings_user_passw.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_settings_user_passw.Name = "tb_settings_user_passw";
            this.tt_settings.SetToolTip(this.tb_settings_user_passw, resources.GetString("tb_settings_user_passw.ToolTip"));
            // 
            // lb_settings_user_usrpwdtitel
            // 
            resources.ApplyResources(this.lb_settings_user_usrpwdtitel, "lb_settings_user_usrpwdtitel");
            this.lb_settings_user_usrpwdtitel.Name = "lb_settings_user_usrpwdtitel";
            this.tt_settings.SetToolTip(this.lb_settings_user_usrpwdtitel, resources.GetString("lb_settings_user_usrpwdtitel.ToolTip"));
            // 
            // tb_settings_user_username
            // 
            resources.ApplyResources(this.tb_settings_user_username, "tb_settings_user_username");
            this.tb_settings_user_username.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_settings_user_username.Name = "tb_settings_user_username";
            this.tt_settings.SetToolTip(this.tb_settings_user_username, resources.GetString("tb_settings_user_username.ToolTip"));
            // 
            // lb_settings_user_usrname_titel
            // 
            resources.ApplyResources(this.lb_settings_user_usrname_titel, "lb_settings_user_usrname_titel");
            this.lb_settings_user_usrname_titel.Name = "lb_settings_user_usrname_titel";
            this.tt_settings.SetToolTip(this.lb_settings_user_usrname_titel, resources.GetString("lb_settings_user_usrname_titel.ToolTip"));
            // 
            // pl_settings_generalsettings
            // 
            resources.ApplyResources(this.pl_settings_generalsettings, "pl_settings_generalsettings");
            this.pl_settings_generalsettings.Controls.Add(this.tb_settings_general_pathtoomsidir);
            this.pl_settings_generalsettings.Controls.Add(this.lb_settings_general_pathtoomsidir);
            this.pl_settings_generalsettings.Name = "pl_settings_generalsettings";
            this.tt_settings.SetToolTip(this.pl_settings_generalsettings, resources.GetString("pl_settings_generalsettings.ToolTip"));
            // 
            // tb_settings_general_pathtoomsidir
            // 
            resources.ApplyResources(this.tb_settings_general_pathtoomsidir, "tb_settings_general_pathtoomsidir");
            this.tb_settings_general_pathtoomsidir.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_settings_general_pathtoomsidir.Name = "tb_settings_general_pathtoomsidir";
            this.tb_settings_general_pathtoomsidir.ReadOnly = true;
            this.tt_settings.SetToolTip(this.tb_settings_general_pathtoomsidir, resources.GetString("tb_settings_general_pathtoomsidir.ToolTip"));
            this.tb_settings_general_pathtoomsidir.Click += new System.EventHandler(this.tb_settings_general_pathtoomsidir_Click);
            // 
            // lb_settings_general_pathtoomsidir
            // 
            resources.ApplyResources(this.lb_settings_general_pathtoomsidir, "lb_settings_general_pathtoomsidir");
            this.lb_settings_general_pathtoomsidir.Name = "lb_settings_general_pathtoomsidir";
            this.tt_settings.SetToolTip(this.lb_settings_general_pathtoomsidir, resources.GetString("lb_settings_general_pathtoomsidir.ToolTip"));
            // 
            // fbd_settings
            // 
            resources.ApplyResources(this.fbd_settings, "fbd_settings");
            // 
            // pl_settings_credits
            // 
            resources.ApplyResources(this.pl_settings_credits, "pl_settings_credits");
            this.pl_settings_credits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_settings_credits.Controls.Add(this.llbl_settings_credit_jockie);
            this.pl_settings_credits.Controls.Add(this.llb_settings_credit_kartoffelphantom);
            this.pl_settings_credits.Controls.Add(this.lb_settings_credits_message);
            this.pl_settings_credits.Controls.Add(this.lb_settings_credits_title);
            this.pl_settings_credits.Name = "pl_settings_credits";
            this.tt_settings.SetToolTip(this.pl_settings_credits, resources.GetString("pl_settings_credits.ToolTip"));
            // 
            // llbl_settings_credit_jockie
            // 
            resources.ApplyResources(this.llbl_settings_credit_jockie, "llbl_settings_credit_jockie");
            this.llbl_settings_credit_jockie.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.llbl_settings_credit_jockie.Name = "llbl_settings_credit_jockie";
            this.llbl_settings_credit_jockie.TabStop = true;
            this.tt_settings.SetToolTip(this.llbl_settings_credit_jockie, resources.GetString("llbl_settings_credit_jockie.ToolTip"));
            this.llbl_settings_credit_jockie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_settings_credit_jockie_LinkClicked);
            // 
            // llb_settings_credit_kartoffelphantom
            // 
            resources.ApplyResources(this.llb_settings_credit_kartoffelphantom, "llb_settings_credit_kartoffelphantom");
            this.llb_settings_credit_kartoffelphantom.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.llb_settings_credit_kartoffelphantom.Name = "llb_settings_credit_kartoffelphantom";
            this.llb_settings_credit_kartoffelphantom.TabStop = true;
            this.tt_settings.SetToolTip(this.llb_settings_credit_kartoffelphantom, resources.GetString("llb_settings_credit_kartoffelphantom.ToolTip"));
            this.llb_settings_credit_kartoffelphantom.Click += new System.EventHandler(this.llb_settings_credit_kartoffelphantom_Click);
            // 
            // lb_settings_credits_message
            // 
            resources.ApplyResources(this.lb_settings_credits_message, "lb_settings_credits_message");
            this.lb_settings_credits_message.Name = "lb_settings_credits_message";
            this.tt_settings.SetToolTip(this.lb_settings_credits_message, resources.GetString("lb_settings_credits_message.ToolTip"));
            // 
            // lb_settings_credits_title
            // 
            resources.ApplyResources(this.lb_settings_credits_title, "lb_settings_credits_title");
            this.lb_settings_credits_title.Name = "lb_settings_credits_title";
            this.tt_settings.SetToolTip(this.lb_settings_credits_title, resources.GetString("lb_settings_credits_title.ToolTip"));
            // 
            // pb_settings_generalsettings
            // 
            resources.ApplyResources(this.pb_settings_generalsettings, "pb_settings_generalsettings");
            this.pb_settings_generalsettings.BackgroundImage = global::MOCompany.Properties.Resources.settingsgeneral1;
            this.pb_settings_generalsettings.Name = "pb_settings_generalsettings";
            this.pb_settings_generalsettings.TabStop = false;
            this.tt_settings.SetToolTip(this.pb_settings_generalsettings, resources.GetString("pb_settings_generalsettings.ToolTip"));
            // 
            // pb_settings_usersettings
            // 
            resources.ApplyResources(this.pb_settings_usersettings, "pb_settings_usersettings");
            this.pb_settings_usersettings.BackgroundImage = global::MOCompany.Properties.Resources.userdefault;
            this.pb_settings_usersettings.Name = "pb_settings_usersettings";
            this.pb_settings_usersettings.TabStop = false;
            this.tt_settings.SetToolTip(this.pb_settings_usersettings, resources.GetString("pb_settings_usersettings.ToolTip"));
            // 
            // gl_settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_settings_credits);
            this.Controls.Add(this.pl_settings_generalsettings);
            this.Controls.Add(this.pl_settings_usersettings);
            this.Controls.Add(this.btn_settings_save);
            this.Controls.Add(this.pl_settings_leftdock);
            this.Controls.Add(this.pl_settings_headerpanel);
            this.Name = "gl_settings";
            this.tt_settings.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.pl_settings_headerpanel.ResumeLayout(false);
            this.pl_settings_header_pgtitel.ResumeLayout(false);
            this.pl_settings_leftdock.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pl_settings_usersettings.ResumeLayout(false);
            this.pl_settings_usersettings.PerformLayout();
            this.pl_settings_generalsettings.ResumeLayout(false);
            this.pl_settings_generalsettings.PerformLayout();
            this.pl_settings_credits.ResumeLayout(false);
            this.pl_settings_credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings_generalsettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings_usersettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_settings_headerpanel;
        private System.Windows.Forms.Panel pl_settings_header_pgtitel;
        private System.Windows.Forms.Label lb_settings_titleheader;
        private System.Windows.Forms.Button btn_settings_save;
        private System.Windows.Forms.Panel pl_settings_leftdock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_settings_usersettings;
        private System.Windows.Forms.Label lb_settings_nav_usrtitel;
        private System.Windows.Forms.Panel pl_settings_usersettings;
        private System.Windows.Forms.Panel pl_settings_generalsettings;
        private System.Windows.Forms.Label lb_settings_user_usrname_titel;
        private System.Windows.Forms.TextBox tb_settings_user_username;
        private System.Windows.Forms.TextBox tb_settings_user_passw;
        private System.Windows.Forms.Label lb_settings_user_usrpwdtitel;
        private System.Windows.Forms.Label lb_settings_nav_generaltitel;
        private System.Windows.Forms.PictureBox pb_settings_generalsettings;
        private System.Windows.Forms.TextBox tb_settings_general_pathtoomsidir;
        private System.Windows.Forms.Label lb_settings_general_pathtoomsidir;
        private System.Windows.Forms.FolderBrowserDialog fbd_settings;
        private System.Windows.Forms.ToolTip tt_settings;
        private System.Windows.Forms.Label lb_settings_user_hascompanytitle;
        private System.Windows.Forms.Label lb_settings_user_hascompcheck;
        private System.Windows.Forms.Panel pl_settings_credits;
        private System.Windows.Forms.Label lb_settings_credits_title;
        private System.Windows.Forms.Label lb_settings_credits_message;
        private System.Windows.Forms.LinkLabel llb_settings_credit_kartoffelphantom;
        private System.Windows.Forms.LinkLabel llbl_settings_credit_jockie;
    }
}
