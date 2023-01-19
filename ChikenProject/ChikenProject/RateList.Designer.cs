namespace ChikenProject
{
    partial class RateList
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cmbitemType = new Telerik.WinControls.UI.RadDropDownList();
            this.grdRateList = new Telerik.WinControls.UI.RadGridView();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRateList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 74);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Items Rate List";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ChikenProject.Properties.Resources._728933_24;
            this.btnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Location = new System.Drawing.Point(739, 10);
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
            this.btnDelete.Location = new System.Drawing.Point(810, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ThemeName = "Fluent";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel4);
            this.panel2.Controls.Add(this.cmbitemType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 49);
            this.panel2.TabIndex = 48;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 15);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(47, 18);
            this.radLabel4.TabIndex = 24;
            this.radLabel4.Text = "Sort by :";
            this.radLabel4.ThemeName = "Fluent";
            // 
            // cmbitemType
            // 
            this.cmbitemType.AutoSize = false;
            this.cmbitemType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbitemType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem3.Text = "Today";
            radListDataItem4.Text = "All";
            this.cmbitemType.Items.Add(radListDataItem3);
            this.cmbitemType.Items.Add(radListDataItem4);
            this.cmbitemType.Location = new System.Drawing.Point(65, 9);
            this.cmbitemType.Name = "cmbitemType";
            this.cmbitemType.Size = new System.Drawing.Size(210, 31);
            this.cmbitemType.TabIndex = 23;
            this.cmbitemType.ThemeName = "Fluent";
            this.cmbitemType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbitemType_SelectedIndexChanged);
            // 
            // grdRateList
            // 
            this.grdRateList.AutoGenerateHierarchy = true;
            this.grdRateList.AutoScroll = true;
            this.grdRateList.BackColor = System.Drawing.SystemColors.Control;
            this.grdRateList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdRateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRateList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdRateList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdRateList.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdRateList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdRateList.Location = new System.Drawing.Point(0, 123);
            this.grdRateList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdRateList.MasterTemplate.AllowAddNewRow = false;
            this.grdRateList.MasterTemplate.AllowDeleteRow = false;
            this.grdRateList.MasterTemplate.AllowDragToGroup = false;
            this.grdRateList.MasterTemplate.AllowEditRow = false;
            this.grdRateList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdRateList.MasterTemplate.EnableFiltering = true;
            this.grdRateList.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdRateList.MasterTemplate.ShowFilteringRow = false;
            this.grdRateList.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem2.AggregateExpression = null;
            gridViewSummaryItem2.FormatString = "{0}";
            gridViewSummaryItem2.Name = "Count";
            this.grdRateList.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem2}));
            this.grdRateList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdRateList.Name = "grdRateList";
            this.grdRateList.Padding = new System.Windows.Forms.Padding(1);
            this.grdRateList.ReadOnly = true;
            this.grdRateList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdRateList.ShowHeaderCellButtons = true;
            this.grdRateList.Size = new System.Drawing.Size(883, 345);
            this.grdRateList.TabIndex = 49;
            this.grdRateList.ThemeName = "Office2013Light";
            this.grdRateList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GrdRateList_CellClick);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ChikenProject.Properties.Resources._463016_32;
            this.btnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Location = new System.Drawing.Point(668, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 57);
            this.btnNew.TabIndex = 72;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ThemeName = "Fluent";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // RateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 468);
            this.Controls.Add(this.grdRateList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RateList";
            this.Text = "RateList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRateList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cmbitemType;
        private Telerik.WinControls.UI.RadGridView grdRateList;
        private Telerik.WinControls.UI.RadButton btnNew;
    }
}