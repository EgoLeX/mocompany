namespace MOCompany.Controls
{
    partial class own_vehstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(own_vehstore));
            this.pl_header_opnv = new System.Windows.Forms.Panel();
            this.pb_opnvstore_logo = new System.Windows.Forms.PictureBox();
            this.pl_opnvstore_main = new System.Windows.Forms.Panel();
            this.lbox_vehtype = new System.Windows.Forms.ListBox();
            this.lb_opnvstore_welcometxt = new System.Windows.Forms.Label();
            this.lb_opnvstore_choosetype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_opnvstore_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_header_opnv
            // 
            this.pl_header_opnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(186)))), ((int)(((byte)(198)))));
            this.pl_header_opnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header_opnv.Location = new System.Drawing.Point(0, 0);
            this.pl_header_opnv.Name = "pl_header_opnv";
            this.pl_header_opnv.Size = new System.Drawing.Size(858, 89);
            this.pl_header_opnv.TabIndex = 0;
            // 
            // pb_opnvstore_logo
            // 
            this.pb_opnvstore_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_opnvstore_logo.BackgroundImage")));
            this.pb_opnvstore_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_opnvstore_logo.Location = new System.Drawing.Point(706, 3);
            this.pb_opnvstore_logo.Name = "pb_opnvstore_logo";
            this.pb_opnvstore_logo.Size = new System.Drawing.Size(149, 83);
            this.pb_opnvstore_logo.TabIndex = 1;
            this.pb_opnvstore_logo.TabStop = false;
            // 
            // pl_opnvstore_main
            // 
            this.pl_opnvstore_main.Location = new System.Drawing.Point(136, 92);
            this.pl_opnvstore_main.Name = "pl_opnvstore_main";
            this.pl_opnvstore_main.Size = new System.Drawing.Size(719, 524);
            this.pl_opnvstore_main.TabIndex = 2;
            // 
            // lbox_vehtype
            // 
            this.lbox_vehtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(186)))), ((int)(((byte)(198)))));
            this.lbox_vehtype.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_vehtype.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbox_vehtype.FormattingEnabled = true;
            this.lbox_vehtype.ItemHeight = 18;
            this.lbox_vehtype.Items.AddRange(new object[] {
            "Bus",
            "Tram"});
            this.lbox_vehtype.Location = new System.Drawing.Point(3, 253);
            this.lbox_vehtype.Name = "lbox_vehtype";
            this.lbox_vehtype.Size = new System.Drawing.Size(127, 40);
            this.lbox_vehtype.TabIndex = 3;
            this.lbox_vehtype.SelectedIndexChanged += new System.EventHandler(this.lbox_vehtype_SelectedIndexChanged);
            // 
            // lb_opnvstore_welcometxt
            // 
            this.lb_opnvstore_welcometxt.AutoSize = true;
            this.lb_opnvstore_welcometxt.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_opnvstore_welcometxt.Location = new System.Drawing.Point(3, 92);
            this.lb_opnvstore_welcometxt.Name = "lb_opnvstore_welcometxt";
            this.lb_opnvstore_welcometxt.Size = new System.Drawing.Size(129, 117);
            this.lb_opnvstore_welcometxt.TabIndex = 4;
            this.lb_opnvstore_welcometxt.Text = "Welcome at ÖPNV Store\r\n(Vehicle Store)\r\n\r\nWe offer multiple types of\r\nBusses and " +
    "Trams for your\r\npublic transportation \r\ncompany. You can choose\r\nbelow for your " +
    "planned \r\nvehicle type.";
            // 
            // lb_opnvstore_choosetype
            // 
            this.lb_opnvstore_choosetype.AutoSize = true;
            this.lb_opnvstore_choosetype.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_opnvstore_choosetype.Location = new System.Drawing.Point(3, 234);
            this.lb_opnvstore_choosetype.Name = "lb_opnvstore_choosetype";
            this.lb_opnvstore_choosetype.Size = new System.Drawing.Size(119, 13);
            this.lb_opnvstore_choosetype.TabIndex = 5;
            this.lb_opnvstore_choosetype.Text = "Choose Type of Vehicle:";
            // 
            // own_vehstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_opnvstore_choosetype);
            this.Controls.Add(this.lb_opnvstore_welcometxt);
            this.Controls.Add(this.lbox_vehtype);
            this.Controls.Add(this.pl_opnvstore_main);
            this.Controls.Add(this.pb_opnvstore_logo);
            this.Controls.Add(this.pl_header_opnv);
            this.Name = "own_vehstore";
            this.Size = new System.Drawing.Size(858, 619);
            ((System.ComponentModel.ISupportInitialize)(this.pb_opnvstore_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_header_opnv;
        private System.Windows.Forms.PictureBox pb_opnvstore_logo;
        private System.Windows.Forms.Panel pl_opnvstore_main;
        private System.Windows.Forms.ListBox lbox_vehtype;
        private System.Windows.Forms.Label lb_opnvstore_welcometxt;
        private System.Windows.Forms.Label lb_opnvstore_choosetype;
    }
}
