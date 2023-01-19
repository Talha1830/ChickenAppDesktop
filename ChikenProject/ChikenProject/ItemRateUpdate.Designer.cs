namespace ChikenProject
{
    partial class ItemRateUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWholeSalePrice = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtRetailPrice = new Telerik.WinControls.UI.RadSpinEditor();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWholeSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWholeSalePrice);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.txtRetailPrice);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.radLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 264);
            this.panel1.TabIndex = 0;
            // 
            // txtWholeSalePrice
            // 
            this.txtWholeSalePrice.AutoSize = false;
            this.txtWholeSalePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeSalePrice.Location = new System.Drawing.Point(38, 64);
            this.txtWholeSalePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.Size = new System.Drawing.Size(204, 31);
            this.txtWholeSalePrice.TabIndex = 0;
            this.txtWholeSalePrice.ThemeName = "Fluent";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(38, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 18);
            this.radLabel1.TabIndex = 24;
            this.radLabel1.Text = "Whole Sale Price";
            this.radLabel1.ThemeName = "Fluent";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.AutoSize = false;
            this.txtRetailPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetailPrice.Location = new System.Drawing.Point(38, 125);
            this.txtRetailPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(204, 31);
            this.txtRetailPrice.TabIndex = 1;
            this.txtRetailPrice.ThemeName = "Fluent";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(57, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Update";
            this.btnAdd.ThemeName = "Fluent";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(38, 98);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 21);
            this.radLabel3.TabIndex = 23;
            this.radLabel3.Text = "Retail Price";
            this.radLabel3.ThemeName = "Fluent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ItemRateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 344);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ItemRateUpdate";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Price Update";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWholeSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadSpinEditor txtWholeSalePrice;
        private Telerik.WinControls.UI.RadSpinEditor txtRetailPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}