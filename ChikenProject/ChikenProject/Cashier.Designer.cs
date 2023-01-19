namespace ChikenProject
{
    partial class Cashier
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
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem3 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.grdCashier = new Telerik.WinControls.UI.RadGridView();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashier.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 74);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Register Cashier";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ChikenProject.Properties.Resources._728933_24;
            this.btnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Location = new System.Drawing.Point(962, 10);
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
            this.btnDelete.Location = new System.Drawing.Point(1033, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ThemeName = "Fluent";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // grdCashier
            // 
            this.grdCashier.AutoGenerateHierarchy = true;
            this.grdCashier.AutoScroll = true;
            this.grdCashier.BackColor = System.Drawing.SystemColors.Control;
            this.grdCashier.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCashier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdCashier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdCashier.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdCashier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdCashier.Location = new System.Drawing.Point(0, 74);
            this.grdCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdCashier.MasterTemplate.AllowAddNewRow = false;
            this.grdCashier.MasterTemplate.AllowDeleteRow = false;
            this.grdCashier.MasterTemplate.AllowEditRow = false;
            this.grdCashier.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdCashier.MasterTemplate.EnableFiltering = true;
            this.grdCashier.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdCashier.MasterTemplate.ShowFilteringRow = false;
            this.grdCashier.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem3.AggregateExpression = null;
            gridViewSummaryItem3.FormatString = "{0}";
            gridViewSummaryItem3.Name = "Count";
            this.grdCashier.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem3}));
            this.grdCashier.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.grdCashier.Name = "grdCashier";
            this.grdCashier.Padding = new System.Windows.Forms.Padding(1);
            this.grdCashier.ReadOnly = true;
            this.grdCashier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdCashier.ShowHeaderCellButtons = true;
            this.grdCashier.Size = new System.Drawing.Size(1106, 421);
            this.grdCashier.TabIndex = 46;
            this.grdCashier.ThemeName = "Office2013Light";
            this.grdCashier.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GrdCashier_CellClick);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 495);
            this.Controls.Add(this.grdCashier);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashier.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadGridView grdCashier;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}