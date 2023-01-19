namespace ChikenProject
{
    partial class PurchaseStock
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cmbitemType = new Telerik.WinControls.UI.RadDropDownList();
            this.grdpurchaseStock = new Telerik.WinControls.UI.RadGridView();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaseStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaseStock.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 74);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Purchase Stock Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel4);
            this.panel2.Controls.Add(this.cmbitemType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 40);
            this.panel2.TabIndex = 47;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(10, 12);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(66, 18);
            this.radLabel4.TabIndex = 22;
            this.radLabel4.Text = "Select Stock";
            this.radLabel4.ThemeName = "Fluent";
            // 
            // cmbitemType
            // 
            this.cmbitemType.AutoSize = false;
            this.cmbitemType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbitemType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Farmy Chiken";
            radListDataItem2.Text = "Desi Chiken";
            radListDataItem3.Text = "Eggs";
            this.cmbitemType.Items.Add(radListDataItem1);
            this.cmbitemType.Items.Add(radListDataItem2);
            this.cmbitemType.Items.Add(radListDataItem3);
            this.cmbitemType.Location = new System.Drawing.Point(105, 6);
            this.cmbitemType.Name = "cmbitemType";
            this.cmbitemType.Size = new System.Drawing.Size(210, 31);
            this.cmbitemType.TabIndex = 21;
            this.cmbitemType.ThemeName = "Fluent";
            this.cmbitemType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbitemType_SelectedIndexChanged);
            // 
            // grdpurchaseStock
            // 
            this.grdpurchaseStock.AutoGenerateHierarchy = true;
            this.grdpurchaseStock.AutoScroll = true;
            this.grdpurchaseStock.BackColor = System.Drawing.SystemColors.Control;
            this.grdpurchaseStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdpurchaseStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdpurchaseStock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdpurchaseStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdpurchaseStock.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdpurchaseStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdpurchaseStock.Location = new System.Drawing.Point(0, 114);
            this.grdpurchaseStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdpurchaseStock.MasterTemplate.AllowAddNewRow = false;
            this.grdpurchaseStock.MasterTemplate.AllowDeleteRow = false;
            this.grdpurchaseStock.MasterTemplate.AllowDragToGroup = false;
            this.grdpurchaseStock.MasterTemplate.AllowEditRow = false;
            this.grdpurchaseStock.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdpurchaseStock.MasterTemplate.EnableFiltering = true;
            this.grdpurchaseStock.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdpurchaseStock.MasterTemplate.ShowFilteringRow = false;
            this.grdpurchaseStock.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Count";
            this.grdpurchaseStock.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdpurchaseStock.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdpurchaseStock.Name = "grdpurchaseStock";
            this.grdpurchaseStock.Padding = new System.Windows.Forms.Padding(1);
            this.grdpurchaseStock.ReadOnly = true;
            this.grdpurchaseStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdpurchaseStock.ShowHeaderCellButtons = true;
            this.grdpurchaseStock.Size = new System.Drawing.Size(949, 347);
            this.grdpurchaseStock.TabIndex = 48;
            this.grdpurchaseStock.ThemeName = "Office2013Light";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ChikenProject.Properties.Resources._463016_32;
            this.btnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Location = new System.Drawing.Point(872, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 57);
            this.btnNew.TabIndex = 68;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ThemeName = "Fluent";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // PurchaseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 461);
            this.Controls.Add(this.grdpurchaseStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PurchaseStock";
            this.Text = "PurchaseStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaseStock.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpurchaseStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cmbitemType;
        private Telerik.WinControls.UI.RadGridView grdpurchaseStock;
    }
}