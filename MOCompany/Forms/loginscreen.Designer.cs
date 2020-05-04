namespace MOCompany
{
    partial class loginscreen
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginscreen));
            this.pl_loginscreen_footer = new System.Windows.Forms.Panel();
            this.lbl_loginscreen_createdby = new System.Windows.Forms.Label();
            this.btn_loginscreen_close = new System.Windows.Forms.Button();
            this.pl_loginsreen_main = new System.Windows.Forms.Panel();
            this.lbl_loginscreen_version = new System.Windows.Forms.Label();
            this.btn_loginscreen_login = new System.Windows.Forms.Button();
            this.pl_loginscreen_chooseplayoption = new System.Windows.Forms.Panel();
            this.rbtn_driveforyourowncompany = new System.Windows.Forms.RadioButton();
            this.rbtn_loginscreen_driveforacompany = new System.Windows.Forms.RadioButton();
            this.pb_loginscreen_driveforowncompany = new System.Windows.Forms.PictureBox();
            this.pb_loginscreen_driveforcompany = new System.Windows.Forms.PictureBox();
            this.lbl_loginscreen_choosegamemode = new System.Windows.Forms.Label();
            this.llbl_loginscreen_needhelp = new System.Windows.Forms.LinkLabel();
            this.lbl_loginscreen_ps_titel = new System.Windows.Forms.Label();
            this.lbl_loginscreen_loginname_titel = new System.Windows.Forms.Label();
            this.tb_loginscreen_ps = new System.Windows.Forms.TextBox();
            this.tb_loginscreen_name = new System.Windows.Forms.TextBox();
            this.lbl_loginscreen_progname_footer = new System.Windows.Forms.Label();
            this.lbl_loginscreen_progname = new System.Windows.Forms.Label();
            this.ttip_loginscreen = new System.Windows.Forms.ToolTip(this.components);
            this.pl_loginscreen_footer.SuspendLayout();
            this.pl_loginsreen_main.SuspendLayout();
            this.pl_loginscreen_chooseplayoption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginscreen_driveforowncompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginscreen_driveforcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_loginscreen_footer
            // 
            this.pl_loginscreen_footer.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_loginscreen_footer.Controls.Add(this.lbl_loginscreen_createdby);
            this.pl_loginscreen_footer.Controls.Add(this.btn_loginscreen_close);
            resources.ApplyResources(this.pl_loginscreen_footer, "pl_loginscreen_footer");
            this.pl_loginscreen_footer.Name = "pl_loginscreen_footer";
            // 
            // lbl_loginscreen_createdby
            // 
            resources.ApplyResources(this.lbl_loginscreen_createdby, "lbl_loginscreen_createdby");
            this.lbl_loginscreen_createdby.ForeColor = System.Drawing.Color.White;
            this.lbl_loginscreen_createdby.Name = "lbl_loginscreen_createdby";
            // 
            // btn_loginscreen_close
            // 
            resources.ApplyResources(this.btn_loginscreen_close, "btn_loginscreen_close");
            this.btn_loginscreen_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_loginscreen_close.FlatAppearance.BorderSize = 0;
            this.btn_loginscreen_close.Name = "btn_loginscreen_close";
            this.btn_loginscreen_close.TabStop = false;
            this.ttip_loginscreen.SetToolTip(this.btn_loginscreen_close, resources.GetString("btn_loginscreen_close.ToolTip"));
            this.btn_loginscreen_close.UseVisualStyleBackColor = true;
            this.btn_loginscreen_close.Click += new System.EventHandler(this.btn_loginscreen_close_Click);
            // 
            // pl_loginsreen_main
            // 
            this.pl_loginsreen_main.Controls.Add(this.lbl_loginscreen_version);
            this.pl_loginsreen_main.Controls.Add(this.btn_loginscreen_login);
            this.pl_loginsreen_main.Controls.Add(this.pl_loginscreen_chooseplayoption);
            this.pl_loginsreen_main.Controls.Add(this.llbl_loginscreen_needhelp);
            this.pl_loginsreen_main.Controls.Add(this.lbl_loginscreen_ps_titel);
            this.pl_loginsreen_main.Controls.Add(this.lbl_loginscreen_loginname_titel);
            this.pl_loginsreen_main.Controls.Add(this.tb_loginscreen_ps);
            this.pl_loginsreen_main.Controls.Add(this.tb_loginscreen_name);
            this.pl_loginsreen_main.Controls.Add(this.lbl_loginscreen_progname_footer);
            this.pl_loginsreen_main.Controls.Add(this.lbl_loginscreen_progname);
            resources.ApplyResources(this.pl_loginsreen_main, "pl_loginsreen_main");
            this.pl_loginsreen_main.Name = "pl_loginsreen_main";
            // 
            // lbl_loginscreen_version
            // 
            resources.ApplyResources(this.lbl_loginscreen_version, "lbl_loginscreen_version");
            this.lbl_loginscreen_version.Name = "lbl_loginscreen_version";
            // 
            // btn_loginscreen_login
            // 
            resources.ApplyResources(this.btn_loginscreen_login, "btn_loginscreen_login");
            this.btn_loginscreen_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_loginscreen_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginscreen_login.FlatAppearance.BorderSize = 0;
            this.btn_loginscreen_login.ForeColor = System.Drawing.Color.White;
            this.btn_loginscreen_login.Name = "btn_loginscreen_login";
            this.btn_loginscreen_login.UseVisualStyleBackColor = false;
            this.btn_loginscreen_login.Click += new System.EventHandler(this.btn_loginscreen_login_Click);
            // 
            // pl_loginscreen_chooseplayoption
            // 
            this.pl_loginscreen_chooseplayoption.Controls.Add(this.rbtn_driveforyourowncompany);
            this.pl_loginscreen_chooseplayoption.Controls.Add(this.rbtn_loginscreen_driveforacompany);
            this.pl_loginscreen_chooseplayoption.Controls.Add(this.pb_loginscreen_driveforowncompany);
            this.pl_loginscreen_chooseplayoption.Controls.Add(this.pb_loginscreen_driveforcompany);
            this.pl_loginscreen_chooseplayoption.Controls.Add(this.lbl_loginscreen_choosegamemode);
            resources.ApplyResources(this.pl_loginscreen_chooseplayoption, "pl_loginscreen_chooseplayoption");
            this.pl_loginscreen_chooseplayoption.Name = "pl_loginscreen_chooseplayoption";
            // 
            // rbtn_driveforyourowncompany
            // 
            resources.ApplyResources(this.rbtn_driveforyourowncompany, "rbtn_driveforyourowncompany");
            this.rbtn_driveforyourowncompany.Name = "rbtn_driveforyourowncompany";
            this.rbtn_driveforyourowncompany.TabStop = true;
            this.rbtn_driveforyourowncompany.UseVisualStyleBackColor = true;
            // 
            // rbtn_loginscreen_driveforacompany
            // 
            resources.ApplyResources(this.rbtn_loginscreen_driveforacompany, "rbtn_loginscreen_driveforacompany");
            this.rbtn_loginscreen_driveforacompany.Name = "rbtn_loginscreen_driveforacompany";
            this.rbtn_loginscreen_driveforacompany.TabStop = true;
            this.rbtn_loginscreen_driveforacompany.UseVisualStyleBackColor = true;
            // 
            // pb_loginscreen_driveforowncompany
            // 
            resources.ApplyResources(this.pb_loginscreen_driveforowncompany, "pb_loginscreen_driveforowncompany");
            this.pb_loginscreen_driveforowncompany.Name = "pb_loginscreen_driveforowncompany";
            this.pb_loginscreen_driveforowncompany.TabStop = false;
            // 
            // pb_loginscreen_driveforcompany
            // 
            resources.ApplyResources(this.pb_loginscreen_driveforcompany, "pb_loginscreen_driveforcompany");
            this.pb_loginscreen_driveforcompany.Name = "pb_loginscreen_driveforcompany";
            this.pb_loginscreen_driveforcompany.TabStop = false;
            // 
            // lbl_loginscreen_choosegamemode
            // 
            resources.ApplyResources(this.lbl_loginscreen_choosegamemode, "lbl_loginscreen_choosegamemode");
            this.lbl_loginscreen_choosegamemode.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_loginscreen_choosegamemode.Name = "lbl_loginscreen_choosegamemode";
            // 
            // llbl_loginscreen_needhelp
            // 
            this.llbl_loginscreen_needhelp.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.llbl_loginscreen_needhelp, "llbl_loginscreen_needhelp");
            this.llbl_loginscreen_needhelp.Name = "llbl_loginscreen_needhelp";
            this.llbl_loginscreen_needhelp.TabStop = true;
            this.llbl_loginscreen_needhelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_loginscreen_needhelp_LinkClicked);
            // 
            // lbl_loginscreen_ps_titel
            // 
            resources.ApplyResources(this.lbl_loginscreen_ps_titel, "lbl_loginscreen_ps_titel");
            this.lbl_loginscreen_ps_titel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_loginscreen_ps_titel.Name = "lbl_loginscreen_ps_titel";
            // 
            // lbl_loginscreen_loginname_titel
            // 
            resources.ApplyResources(this.lbl_loginscreen_loginname_titel, "lbl_loginscreen_loginname_titel");
            this.lbl_loginscreen_loginname_titel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_loginscreen_loginname_titel.Name = "lbl_loginscreen_loginname_titel";
            // 
            // tb_loginscreen_ps
            // 
            resources.ApplyResources(this.tb_loginscreen_ps, "tb_loginscreen_ps");
            this.tb_loginscreen_ps.Name = "tb_loginscreen_ps";
            // 
            // tb_loginscreen_name
            // 
            resources.ApplyResources(this.tb_loginscreen_name, "tb_loginscreen_name");
            this.tb_loginscreen_name.Name = "tb_loginscreen_name";
            // 
            // lbl_loginscreen_progname_footer
            // 
            resources.ApplyResources(this.lbl_loginscreen_progname_footer, "lbl_loginscreen_progname_footer");
            this.lbl_loginscreen_progname_footer.Name = "lbl_loginscreen_progname_footer";
            // 
            // lbl_loginscreen_progname
            // 
            resources.ApplyResources(this.lbl_loginscreen_progname, "lbl_loginscreen_progname");
            this.lbl_loginscreen_progname.Name = "lbl_loginscreen_progname";
            // 
            // loginscreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_loginsreen_main);
            this.Controls.Add(this.pl_loginscreen_footer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginscreen";
            this.pl_loginscreen_footer.ResumeLayout(false);
            this.pl_loginscreen_footer.PerformLayout();
            this.pl_loginsreen_main.ResumeLayout(false);
            this.pl_loginsreen_main.PerformLayout();
            this.pl_loginscreen_chooseplayoption.ResumeLayout(false);
            this.pl_loginscreen_chooseplayoption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginscreen_driveforowncompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginscreen_driveforcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_loginscreen_footer;
        private System.Windows.Forms.Button btn_loginscreen_close;
        private System.Windows.Forms.Label lbl_loginscreen_createdby;
        private System.Windows.Forms.Panel pl_loginsreen_main;
        private System.Windows.Forms.Label lbl_loginscreen_progname_footer;
        private System.Windows.Forms.Label lbl_loginscreen_progname;
        private System.Windows.Forms.TextBox tb_loginscreen_name;
        private System.Windows.Forms.Label lbl_loginscreen_ps_titel;
        private System.Windows.Forms.Label lbl_loginscreen_loginname_titel;
        private System.Windows.Forms.LinkLabel llbl_loginscreen_needhelp;
        private System.Windows.Forms.Panel pl_loginscreen_chooseplayoption;
        private System.Windows.Forms.Button btn_loginscreen_login;
        private System.Windows.Forms.TextBox tb_loginscreen_ps;
        private System.Windows.Forms.Label lbl_loginscreen_choosegamemode;
        private System.Windows.Forms.RadioButton rbtn_driveforyourowncompany;
        private System.Windows.Forms.RadioButton rbtn_loginscreen_driveforacompany;
        private System.Windows.Forms.PictureBox pb_loginscreen_driveforowncompany;
        private System.Windows.Forms.PictureBox pb_loginscreen_driveforcompany;
        private System.Windows.Forms.ToolTip ttip_loginscreen;
        private System.Windows.Forms.Label lbl_loginscreen_version;
    }
}

