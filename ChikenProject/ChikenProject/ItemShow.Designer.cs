namespace ChikenProject
{
    partial class ItemShow
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
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grditem = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.grditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grditem.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // grditem
            // 
            this.grditem.AutoGenerateHierarchy = true;
            this.grditem.AutoScroll = true;
            this.grditem.BackColor = System.Drawing.SystemColors.Control;
            this.grditem.Cursor = System.Windows.Forms.Cursors.Default;
            this.grditem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grditem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grditem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grditem.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grditem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grditem.Location = new System.Drawing.Point(0, 74);
            this.grditem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grditem.MasterTemplate.AllowAddNewRow = false;
            this.grditem.MasterTemplate.AllowDeleteRow = false;
            this.grditem.MasterTemplate.AllowEditRow = false;
            this.grditem.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grditem.MasterTemplate.EnableFiltering = true;
            this.grditem.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grditem.MasterTemplate.ShowFilteringRow = false;
            this.grditem.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem2.AggregateExpression = null;
            gridViewSummaryItem2.FormatString = "{0}";
            gridViewSummaryItem2.Name = "Count";
            this.grditem.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem2}));
            this.grditem.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grditem.Name = "grditem";
            this.grditem.Padding = new System.Windows.Forms.Padding(1);
            this.grditem.ReadOnly = true;
            this.grditem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grditem.ShowHeaderCellButtons = true;
            this.grditem.Size = new System.Drawing.Size(987, 408);
            this.grditem.TabIndex = 43;
            this.grditem.ThemeName = "Office2013Light";
            this.grditem.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Grditem_CellClick);
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
            this.panel1.Size = new System.Drawing.Size(987, 74);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "items Information";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ChikenProject.Properties.Resources._463016_32;
            this.btnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Location = new System.Drawing.Point(772, 10);
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
            this.btnEdit.Location = new System.Drawing.Point(843, 10);
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
            this.btnDelete.Location = new System.Drawing.Point(914, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ThemeName = "Fluent";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ItemShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 482);
            this.Controls.Add(this.grditem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemShow";
            this.Text = "ItemShow";
            ((System.ComponentModel.ISupportInitialize)(this.grditem.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grditem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grditem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}