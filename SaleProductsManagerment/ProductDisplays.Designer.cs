namespace SaleProductsManagerment
{
    partial class ProductDisplays
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGrid = new DataGridView();
            searchController = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = SystemColors.Control;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Khmer OS", 12.1121492F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Khmer OS", 10.0934572F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Margin = new Padding(10);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 46;
            dataGrid.RowTemplate.Height = 27;
            dataGrid.Size = new Size(982, 359);
            dataGrid.TabIndex = 0;
            // 
            // searchController
            // 
            searchController.Anchor = AnchorStyles.Top;
            searchController.Font = new Font("Segoe UI Semibold", 10.7663546F, FontStyle.Bold, GraphicsUnit.Point);
            searchController.Location = new Point(579, 407);
            searchController.Margin = new Padding(0, 0, 30, 0);
            searchController.Name = "searchController";
            searchController.Size = new Size(267, 29);
            searchController.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(873, 407);
            btnSearch.Margin = new Padding(0, 0, 30, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "ស្វែងរកទំនិញ";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // ProductDisplays
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(982, 459);
            Controls.Add(btnSearch);
            Controls.Add(searchController);
            Controls.Add(dataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDisplays";
            Text = "ProductDisplays";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private TextBox searchController;
        private Button btnSearch;
    }
}