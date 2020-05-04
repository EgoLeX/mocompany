namespace MOCompany.Controls
{
    partial class own_managment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_managment_compname = new System.Windows.Forms.Label();
            this.pl_managment_main = new System.Windows.Forms.Panel();
            this.tt_own_management_main = new System.Windows.Forms.ToolTip(this.components);
            this.btn_managment_nav_employees = new System.Windows.Forms.Button();
            this.btn_managment_nav_carpool = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_managment_nav_employees);
            this.panel1.Controls.Add(this.btn_managment_nav_carpool);
            this.panel1.Controls.Add(this.lb_managment_compname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 58);
            this.panel1.TabIndex = 0;
            // 
            // lb_managment_compname
            // 
            this.lb_managment_compname.AutoSize = true;
            this.lb_managment_compname.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_managment_compname.ForeColor = System.Drawing.Color.White;
            this.lb_managment_compname.Location = new System.Drawing.Point(12, 20);
            this.lb_managment_compname.Name = "lb_managment_compname";
            this.lb_managment_compname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_managment_compname.Size = new System.Drawing.Size(130, 19);
            this.lb_managment_compname.TabIndex = 0;
            this.lb_managment_compname.Text = "mycompanyname";
            this.lb_managment_compname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_managment_main
            // 
            this.pl_managment_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_managment_main.Location = new System.Drawing.Point(0, 58);
            this.pl_managment_main.Name = "pl_managment_main";
            this.pl_managment_main.Size = new System.Drawing.Size(858, 561);
            this.pl_managment_main.TabIndex = 1;
            // 
            // btn_managment_nav_employees
            // 
            this.btn_managment_nav_employees.BackgroundImage = global::MOCompany.Properties.Resources.employee;
            this.btn_managment_nav_employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_managment_nav_employees.FlatAppearance.BorderSize = 0;
            this.btn_managment_nav_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managment_nav_employees.Location = new System.Drawing.Point(732, 6);
            this.btn_managment_nav_employees.Name = "btn_managment_nav_employees";
            this.btn_managment_nav_employees.Size = new System.Drawing.Size(49, 49);
            this.btn_managment_nav_employees.TabIndex = 3;
            this.tt_own_management_main.SetToolTip(this.btn_managment_nav_employees, "Employees");
            this.btn_managment_nav_employees.UseVisualStyleBackColor = true;
            // 
            // btn_managment_nav_carpool
            // 
            this.btn_managment_nav_carpool.BackgroundImage = global::MOCompany.Properties.Resources.carpool;
            this.btn_managment_nav_carpool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_managment_nav_carpool.FlatAppearance.BorderSize = 0;
            this.btn_managment_nav_carpool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managment_nav_carpool.Location = new System.Drawing.Point(796, 6);
            this.btn_managment_nav_carpool.Name = "btn_managment_nav_carpool";
            this.btn_managment_nav_carpool.Size = new System.Drawing.Size(49, 49);
            this.btn_managment_nav_carpool.TabIndex = 2;
            this.tt_own_management_main.SetToolTip(this.btn_managment_nav_carpool, "Carpool");
            this.btn_managment_nav_carpool.UseVisualStyleBackColor = true;
            this.btn_managment_nav_carpool.Click += new System.EventHandler(this.btn_managment_nav_carpool_Click);
            // 
            // own_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_managment_main);
            this.Controls.Add(this.panel1);
            this.Name = "own_managment";
            this.Size = new System.Drawing.Size(858, 619);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_managment_compname;
        private System.Windows.Forms.Panel pl_managment_main;
        private System.Windows.Forms.ToolTip tt_own_management_main;
        private System.Windows.Forms.Button btn_managment_nav_carpool;
        private System.Windows.Forms.Button btn_managment_nav_employees;
    }
}
