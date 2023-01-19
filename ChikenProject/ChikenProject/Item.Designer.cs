namespace ChikenProject
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWholeSale = new Telerik.WinControls.UI.RadSpinEditor();
            this.txtRetail = new Telerik.WinControls.UI.RadSpinEditor();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtWholeSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWholeSale
            // 
            this.txtWholeSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeSale.Location = new System.Drawing.Point(33, 82);
            this.txtWholeSale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtWholeSale.Name = "txtWholeSale";
            this.txtWholeSale.Size = new System.Drawing.Size(115, 27);
            this.txtWholeSale.TabIndex = 0;
            this.txtWholeSale.ThemeName = "Fluent";
            // 
            // txtRetail
            // 
            this.txtRetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetail.Location = new System.Drawing.Point(33, 157);
            this.txtRetail.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtRetail.Name = "txtRetail";
            this.txtRetail.Size = new System.Drawing.Size(115, 27);
            this.txtRetail.TabIndex = 1;
            this.txtRetail.ThemeName = "Fluent";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(33, 61);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 18);
            this.radLabel1.TabIndex = 16;
            this.radLabel1.Text = "Whole Sale Price";
            this.radLabel1.ThemeName = "Fluent";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(33, 136);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 18);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "Retail Price";
            this.radLabel2.ThemeName = "Fluent";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 43);
            this.panel1.TabIndex = 18;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(42, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(99, 25);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "itemName";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtRetail);
            this.Controls.Add(this.txtWholeSale);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(178, 205);
            ((System.ComponentModel.ISupportInitialize)(this.txtWholeSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblItemName;
        public Telerik.WinControls.UI.RadSpinEditor txtWholeSale;
        public Telerik.WinControls.UI.RadSpinEditor txtRetail;
    }
}
