namespace MOCompany.Controls
{
    partial class gl_drive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gl_drive));
            this.lb_drive_titleheader = new System.Windows.Forms.Label();
            this.pl_drive_headerpanel = new System.Windows.Forms.Panel();
            this.pl_settings_header_pgtitel = new System.Windows.Forms.Panel();
            this.btn_drive_startdriving = new System.Windows.Forms.Button();
            this.lb_drive_evaluation_titel = new System.Windows.Forms.Label();
            this.btn_drive_acceptdrive = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_drive_evaluation = new System.Windows.Forms.RichTextBox();
            this.pl_drive_headerpanel.SuspendLayout();
            this.pl_settings_header_pgtitel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_drive_titleheader
            // 
            resources.ApplyResources(this.lb_drive_titleheader, "lb_drive_titleheader");
            this.lb_drive_titleheader.ForeColor = System.Drawing.Color.White;
            this.lb_drive_titleheader.Name = "lb_drive_titleheader";
            // 
            // pl_drive_headerpanel
            // 
            resources.ApplyResources(this.pl_drive_headerpanel, "pl_drive_headerpanel");
            this.pl_drive_headerpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pl_drive_headerpanel.Controls.Add(this.pl_settings_header_pgtitel);
            this.pl_drive_headerpanel.Name = "pl_drive_headerpanel";
            // 
            // pl_settings_header_pgtitel
            // 
            resources.ApplyResources(this.pl_settings_header_pgtitel, "pl_settings_header_pgtitel");
            this.pl_settings_header_pgtitel.BackColor = System.Drawing.Color.SteelBlue;
            this.pl_settings_header_pgtitel.Controls.Add(this.lb_drive_titleheader);
            this.pl_settings_header_pgtitel.Name = "pl_settings_header_pgtitel";
            // 
            // btn_drive_startdriving
            // 
            resources.ApplyResources(this.btn_drive_startdriving, "btn_drive_startdriving");
            this.btn_drive_startdriving.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_drive_startdriving.FlatAppearance.BorderSize = 0;
            this.btn_drive_startdriving.ForeColor = System.Drawing.Color.White;
            this.btn_drive_startdriving.Name = "btn_drive_startdriving";
            this.btn_drive_startdriving.UseVisualStyleBackColor = false;
            this.btn_drive_startdriving.Click += new System.EventHandler(this.btn_drive_startdriving_Click);
            // 
            // lb_drive_evaluation_titel
            // 
            resources.ApplyResources(this.lb_drive_evaluation_titel, "lb_drive_evaluation_titel");
            this.lb_drive_evaluation_titel.Name = "lb_drive_evaluation_titel";
            // 
            // btn_drive_acceptdrive
            // 
            resources.ApplyResources(this.btn_drive_acceptdrive, "btn_drive_acceptdrive");
            this.btn_drive_acceptdrive.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_drive_acceptdrive.FlatAppearance.BorderSize = 0;
            this.btn_drive_acceptdrive.ForeColor = System.Drawing.Color.White;
            this.btn_drive_acceptdrive.Name = "btn_drive_acceptdrive";
            this.btn_drive_acceptdrive.UseVisualStyleBackColor = false;
            this.btn_drive_acceptdrive.Click += new System.EventHandler(this.btn_drive_acceptdrive_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_drive_acceptdrive);
            this.panel1.Name = "panel1";
            // 
            // rtb_drive_evaluation
            // 
            resources.ApplyResources(this.rtb_drive_evaluation, "rtb_drive_evaluation");
            this.rtb_drive_evaluation.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_drive_evaluation.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_drive_evaluation.Name = "rtb_drive_evaluation";
            this.rtb_drive_evaluation.ReadOnly = true;
            // 
            // gl_drive
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb_drive_evaluation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_drive_evaluation_titel);
            this.Controls.Add(this.btn_drive_startdriving);
            this.Controls.Add(this.pl_drive_headerpanel);
            this.Name = "gl_drive";
            this.pl_drive_headerpanel.ResumeLayout(false);
            this.pl_settings_header_pgtitel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_drive_titleheader;
        private System.Windows.Forms.Panel pl_drive_headerpanel;
        private System.Windows.Forms.Panel pl_settings_header_pgtitel;
        private System.Windows.Forms.Button btn_drive_startdriving;
        private System.Windows.Forms.Label lb_drive_evaluation_titel;
        private System.Windows.Forms.Button btn_drive_acceptdrive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_drive_evaluation;
    }
}
