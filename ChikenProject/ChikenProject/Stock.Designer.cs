namespace ChikenProject
{
    partial class Stock
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdStock = new Telerik.WinControls.UI.RadGridView();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.cmbitemType = new Telerik.WinControls.UI.RadDropDownList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 74);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Daily Stock Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel4);
            this.panel2.Controls.Add(this.cmbitemType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 48);
            this.panel2.TabIndex = 49;
            // 
            // grdStock
            // 
            this.grdStock.AutoGenerateHierarchy = true;
            this.grdStock.AutoScroll = true;
            this.grdStock.BackColor = System.Drawing.SystemColors.Control;
            this.grdStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdStock.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdStock.Location = new System.Drawing.Point(0, 122);
            this.grdStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdStock.MasterTemplate.AllowAddNewRow = false;
            this.grdStock.MasterTemplate.AllowDeleteRow = false;
            this.grdStock.MasterTemplate.AllowDragToGroup = false;
            this.grdStock.MasterTemplate.AllowEditRow = false;
            this.grdStock.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdStock.MasterTemplate.EnableFiltering = true;
            this.grdStock.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdStock.MasterTemplate.ShowFilteringRow = false;
            this.grdStock.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Count";
            this.grdStock.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdStock.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdStock.Name = "grdStock";
            this.grdStock.Padding = new System.Windows.Forms.Padding(1);
            this.grdStock.ReadOnly = true;
            this.grdStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdStock.ShowHeaderCellButtons = true;
            this.grdStock.Size = new System.Drawing.Size(903, 368);
            this.grdStock.TabIndex = 50;
            this.grdStock.ThemeName = "Office2013Light";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(18, 15);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(66, 18);
            this.radLabel4.TabIndex = 26;
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
            radListDataItem3.Text = "Egg";
            this.cmbitemType.Items.Add(radListDataItem1);
            this.cmbitemType.Items.Add(radListDataItem2);
            this.cmbitemType.Items.Add(radListDataItem3);
            this.cmbitemType.Location = new System.Drawing.Point(93, 9);
            this.cmbitemType.Name = "cmbitemType";
            this.cmbitemType.Size = new System.Drawing.Size(210, 31);
            this.cmbitemType.TabIndex = 25;
            this.cmbitemType.ThemeName = "Fluent";
            this.cmbitemType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbitemType_SelectedIndexChanged);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.grdStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Stock";
            this.Text = "Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbitemType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView grdStock;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList cmbitemType;
    }
}