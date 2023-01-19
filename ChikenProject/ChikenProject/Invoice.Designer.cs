namespace ChikenProject
{
    partial class Invoice
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
            this.grdincoices = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.grdincoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdincoices.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdincoices
            // 
            this.grdincoices.AutoGenerateHierarchy = true;
            this.grdincoices.AutoScroll = true;
            this.grdincoices.BackColor = System.Drawing.SystemColors.Control;
            this.grdincoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdincoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdincoices.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdincoices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdincoices.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdincoices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdincoices.Location = new System.Drawing.Point(0, 74);
            this.grdincoices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdincoices.MasterTemplate.AllowAddNewRow = false;
            this.grdincoices.MasterTemplate.AllowDeleteRow = false;
            this.grdincoices.MasterTemplate.AllowDragToGroup = false;
            this.grdincoices.MasterTemplate.AllowEditRow = false;
            this.grdincoices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdincoices.MasterTemplate.EnableFiltering = true;
            this.grdincoices.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdincoices.MasterTemplate.ShowFilteringRow = false;
            this.grdincoices.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Count";
            this.grdincoices.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdincoices.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdincoices.Name = "grdincoices";
            this.grdincoices.Padding = new System.Windows.Forms.Padding(1);
            this.grdincoices.ReadOnly = true;
            this.grdincoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdincoices.ShowHeaderCellButtons = true;
            this.grdincoices.Size = new System.Drawing.Size(1027, 407);
            this.grdincoices.TabIndex = 45;
            this.grdincoices.ThemeName = "Office2013Light";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 74);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Customer Invoices";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 481);
            this.Controls.Add(this.grdincoices);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Invoice";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.grdincoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdincoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdincoices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}