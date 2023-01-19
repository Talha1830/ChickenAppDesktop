namespace ChikenProject
{
    partial class Expenses
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
            this.grdExpenses = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdExpenses
            // 
            this.grdExpenses.AutoGenerateHierarchy = true;
            this.grdExpenses.AutoScroll = true;
            this.grdExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.grdExpenses.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExpenses.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdExpenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdExpenses.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.grdExpenses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdExpenses.Location = new System.Drawing.Point(0, 74);
            this.grdExpenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.grdExpenses.MasterTemplate.AllowAddNewRow = false;
            this.grdExpenses.MasterTemplate.AllowDeleteRow = false;
            this.grdExpenses.MasterTemplate.AllowDragToGroup = false;
            this.grdExpenses.MasterTemplate.AllowEditRow = false;
            this.grdExpenses.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdExpenses.MasterTemplate.EnableFiltering = true;
            this.grdExpenses.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.grdExpenses.MasterTemplate.ShowFilteringRow = false;
            this.grdExpenses.MasterTemplate.ShowHeaderCellButtons = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Count";
            this.grdExpenses.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdExpenses.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdExpenses.Name = "grdExpenses";
            this.grdExpenses.Padding = new System.Windows.Forms.Padding(1);
            this.grdExpenses.ReadOnly = true;
            this.grdExpenses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdExpenses.ShowHeaderCellButtons = true;
            this.grdExpenses.Size = new System.Drawing.Size(1053, 433);
            this.grdExpenses.TabIndex = 47;
            this.grdExpenses.ThemeName = "Office2013Light";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 74);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Daily Expenses";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 507);
            this.Controls.Add(this.grdExpenses);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Expenses";
            this.Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdExpenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}