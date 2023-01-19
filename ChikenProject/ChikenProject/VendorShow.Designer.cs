namespace ChikenProject
{
    partial class VendorShow
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
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.grdVendor = new Telerik.WinControls.UI.RadGridView();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Vendors Information";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ChikenProject.Properties.Resources._463016_32;
            this.btnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Location = new System.Drawing.Point(773, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 57);
            this.btnNew.TabIndex = 68;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ThemeName = "Fluent";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ChikenProject.Properties.Resources._728933_24;
            this.btnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Location = new System.Drawing.Point(844, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 57);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.ThemeName = "Fluent";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ChikenProject.Properties.Resources._616650_24;
            this.btnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(915, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ThemeName = "Fluent";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // grdVendor
            // 
            this.grdVendor.AutoGenerateHierarchy = true;
            this.grdVendor.AutoScroll = true;
            this.grdVendor.BackColor = System.Drawing.SystemColors.Control;
            this.grdVendor.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVendor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdVendor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdVendor.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdVendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdVendor.Location = new System.Drawing.Point(0, 74);
            this.grdVendor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdVendor.MasterTemplate.AllowAddNewRow = false;
            this.grdVendor.MasterTemplate.AllowDeleteRow = false;
            this.grdVendor.MasterTemplate.AllowEditRow = false;
            this.grdVendor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdVendor.MasterTemplate.EnableFiltering = true;
            this.grdVendor.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdVendor.MasterTemplate.ShowFilteringRow = false;
            this.grdVendor.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Count";
            this.grdVendor.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdVendor.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdVendor.Name = "grdVendor";
            this.grdVendor.Padding = new System.Windows.Forms.Padding(1);
            this.grdVendor.ReadOnly = true;
            this.grdVendor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdVendor.ShowHeaderCellButtons = true;
            this.grdVendor.Size = new System.Drawing.Size(988, 445);
            this.grdVendor.TabIndex = 41;
            this.grdVendor.ThemeName = "Office2013Light";
            this.grdVendor.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GrdVendor_CellClick);
            // 
            // VendorShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 519);
            this.Controls.Add(this.grdVendor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendorShow";
            this.Text = "VendorShow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView grdVendor;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}