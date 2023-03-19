namespace SaleProductsManagerment
{
    partial class FormAboutProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProduct));
            panel_showTitleProduct = new Panel();
            labelInfoProduct = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxDeleteController = new PictureBox();
            pictureBoxShortController = new PictureBox();
            pictureBoxAddBtnController = new PictureBox();
            pictureBoxShowProduct = new PictureBox();
            labelDeleteController = new Label();
            labelShortController = new Label();
            labelAddControllerBtn = new Label();
            labelShowProduct = new Label();
            btnDeleteController = new Button();
            btnShortController = new Button();
            btnAddController = new Button();
            pictureBox1 = new PictureBox();
            btnShowProductController = new Button();
            panelControllerPage = new Panel();
            panel_showTitleProduct.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShortController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddBtnController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_showTitleProduct
            // 
            panel_showTitleProduct.Anchor = AnchorStyles.None;
            panel_showTitleProduct.AutoSize = true;
            panel_showTitleProduct.BackColor = SystemColors.Window;
            panel_showTitleProduct.Controls.Add(labelInfoProduct);
            panel_showTitleProduct.Location = new Point(406, 6);
            panel_showTitleProduct.Name = "panel_showTitleProduct";
            panel_showTitleProduct.Size = new Size(381, 76);
            panel_showTitleProduct.TabIndex = 2;
            // 
            // labelInfoProduct
            // 
            labelInfoProduct.AutoSize = true;
            labelInfoProduct.Font = new Font("Khmer OS Muol", 16.1495323F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfoProduct.Location = new Point(78, 13);
            labelInfoProduct.Name = "labelInfoProduct";
            labelInfoProduct.Size = new Size(239, 49);
            labelInfoProduct.TabIndex = 0;
            labelInfoProduct.Text = "ព័ត៌មានអំពីទំនិញ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(panel_showTitleProduct);
            panel1.Location = new Point(142, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 91);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoSize = true;
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(pictureBoxDeleteController);
            panel2.Controls.Add(pictureBoxShortController);
            panel2.Controls.Add(pictureBoxAddBtnController);
            panel2.Controls.Add(pictureBoxShowProduct);
            panel2.Controls.Add(labelDeleteController);
            panel2.Controls.Add(labelShortController);
            panel2.Controls.Add(labelAddControllerBtn);
            panel2.Controls.Add(labelShowProduct);
            panel2.Controls.Add(btnDeleteController);
            panel2.Controls.Add(btnShortController);
            panel2.Controls.Add(btnAddController);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnShowProductController);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 651);
            panel2.TabIndex = 3;
            // 
            // pictureBoxDeleteController
            // 
            pictureBoxDeleteController.BackColor = Color.White;
            pictureBoxDeleteController.BackgroundImage = (Image)resources.GetObject("pictureBoxDeleteController.BackgroundImage");
            pictureBoxDeleteController.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxDeleteController.Location = new Point(26, 447);
            pictureBoxDeleteController.Name = "pictureBoxDeleteController";
            pictureBoxDeleteController.Size = new Size(51, 42);
            pictureBoxDeleteController.TabIndex = 3;
            pictureBoxDeleteController.TabStop = false;
            pictureBoxDeleteController.Click += DeletClickEvent;
            pictureBoxDeleteController.MouseEnter += DeleteEnterProduct;
            pictureBoxDeleteController.MouseLeave += DeleteLeaveEvent;
            // 
            // pictureBoxShortController
            // 
            pictureBoxShortController.BackColor = Color.White;
            pictureBoxShortController.BackgroundImage = (Image)resources.GetObject("pictureBoxShortController.BackgroundImage");
            pictureBoxShortController.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxShortController.Location = new Point(26, 348);
            pictureBoxShortController.Name = "pictureBoxShortController";
            pictureBoxShortController.Size = new Size(51, 42);
            pictureBoxShortController.TabIndex = 3;
            pictureBoxShortController.TabStop = false;
            pictureBoxShortController.Click += SortEventProduct;
            pictureBoxShortController.MouseEnter += ShortEnterProduct;
            pictureBoxShortController.MouseLeave += ShortLeaveProductEvent;
            // 
            // pictureBoxAddBtnController
            // 
            pictureBoxAddBtnController.BackColor = Color.White;
            pictureBoxAddBtnController.BackgroundImage = (Image)resources.GetObject("pictureBoxAddBtnController.BackgroundImage");
            pictureBoxAddBtnController.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAddBtnController.Location = new Point(26, 252);
            pictureBoxAddBtnController.Name = "pictureBoxAddBtnController";
            pictureBoxAddBtnController.Size = new Size(51, 42);
            pictureBoxAddBtnController.TabIndex = 3;
            pictureBoxAddBtnController.TabStop = false;
            pictureBoxAddBtnController.Click += EventAddProduct;
            pictureBoxAddBtnController.MouseEnter += EnterAddProduct;
            pictureBoxAddBtnController.MouseLeave += LeaveAddProduct;
            // 
            // pictureBoxShowProduct
            // 
            pictureBoxShowProduct.BackColor = Color.White;
            pictureBoxShowProduct.BackgroundImage = (Image)resources.GetObject("pictureBoxShowProduct.BackgroundImage");
            pictureBoxShowProduct.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxShowProduct.Location = new Point(26, 162);
            pictureBoxShowProduct.Name = "pictureBoxShowProduct";
            pictureBoxShowProduct.Size = new Size(51, 42);
            pictureBoxShowProduct.TabIndex = 3;
            pictureBoxShowProduct.TabStop = false;
            pictureBoxShowProduct.Click += EventShowProduct;
            pictureBoxShowProduct.MouseEnter += EnterShowPro;
            pictureBoxShowProduct.MouseLeave += LeaveShowPro;
            // 
            // labelDeleteController
            // 
            labelDeleteController.AutoSize = true;
            labelDeleteController.BackColor = Color.White;
            labelDeleteController.Font = new Font("Khmer OS Battambang", 10.0934572F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeleteController.Location = new Point(78, 457);
            labelDeleteController.Name = "labelDeleteController";
            labelDeleteController.Size = new Size(77, 27);
            labelDeleteController.TabIndex = 2;
            labelDeleteController.Text = "លុបទំនិញ";
            labelDeleteController.Click += DeletClickEvent;
            labelDeleteController.MouseEnter += DeleteEnterProduct;
            labelDeleteController.MouseLeave += DeleteLeaveEvent;
            // 
            // labelShortController
            // 
            labelShortController.AutoSize = true;
            labelShortController.BackColor = Color.White;
            labelShortController.Font = new Font("Khmer OS Battambang", 10.0934572F, FontStyle.Bold, GraphicsUnit.Point);
            labelShortController.Location = new Point(78, 358);
            labelShortController.Name = "labelShortController";
            labelShortController.Size = new Size(90, 27);
            labelShortController.TabIndex = 2;
            labelShortController.Text = "តំរៀបទំនិញ";
            labelShortController.Click += SortEventProduct;
            labelShortController.MouseEnter += ShortEnterProduct;
            labelShortController.MouseLeave += ShortLeaveProductEvent;
            // 
            // labelAddControllerBtn
            // 
            labelAddControllerBtn.AutoSize = true;
            labelAddControllerBtn.BackColor = Color.White;
            labelAddControllerBtn.Font = new Font("Khmer OS Battambang", 10.0934572F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddControllerBtn.Location = new Point(79, 262);
            labelAddControllerBtn.Name = "labelAddControllerBtn";
            labelAddControllerBtn.Size = new Size(89, 27);
            labelAddControllerBtn.TabIndex = 2;
            labelAddControllerBtn.Text = "បន្ថែមទំនិញ";
            labelAddControllerBtn.Click += EventAddProduct;
            labelAddControllerBtn.MouseEnter += EnterAddProduct;
            labelAddControllerBtn.MouseLeave += LeaveAddProduct;
            // 
            // labelShowProduct
            // 
            labelShowProduct.AutoSize = true;
            labelShowProduct.BackColor = Color.White;
            labelShowProduct.Font = new Font("Khmer OS Battambang", 10.0934572F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowProduct.Location = new Point(79, 172);
            labelShowProduct.Name = "labelShowProduct";
            labelShowProduct.Size = new Size(93, 27);
            labelShowProduct.TabIndex = 2;
            labelShowProduct.Text = "បង្ហាញទំនិញ";
            labelShowProduct.Click += EventShowProduct;
            labelShowProduct.MouseEnter += EnterShowPro;
            labelShowProduct.MouseLeave += LeaveShowPro;
            // 
            // btnDeleteController
            // 
            btnDeleteController.BackColor = Color.White;
            btnDeleteController.Location = new Point(19, 442);
            btnDeleteController.Name = "btnDeleteController";
            btnDeleteController.Size = new Size(158, 54);
            btnDeleteController.TabIndex = 0;
            btnDeleteController.UseVisualStyleBackColor = false;
            btnDeleteController.Click += DeletClickEvent;
            btnDeleteController.MouseEnter += DeleteEnterProduct;
            btnDeleteController.MouseLeave += DeleteLeaveEvent;
            // 
            // btnShortController
            // 
            btnShortController.BackColor = Color.White;
            btnShortController.Location = new Point(19, 343);
            btnShortController.Name = "btnShortController";
            btnShortController.Size = new Size(158, 54);
            btnShortController.TabIndex = 0;
            btnShortController.UseVisualStyleBackColor = false;
            btnShortController.Click += SortEventProduct;
            btnShortController.MouseEnter += ShortEnterProduct;
            btnShortController.MouseLeave += ShortLeaveProductEvent;
            // 
            // btnAddController
            // 
            btnAddController.BackColor = Color.White;
            btnAddController.Location = new Point(19, 247);
            btnAddController.Name = "btnAddController";
            btnAddController.Size = new Size(158, 54);
            btnAddController.TabIndex = 0;
            btnAddController.UseVisualStyleBackColor = false;
            btnAddController.Click += EventAddProduct;
            btnAddController.MouseEnter += EnterAddProduct;
            btnAddController.MouseLeave += LeaveAddProduct;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(52, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 71);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnShowProductController
            // 
            btnShowProductController.BackColor = Color.White;
            btnShowProductController.Location = new Point(19, 157);
            btnShowProductController.Name = "btnShowProductController";
            btnShowProductController.Size = new Size(158, 54);
            btnShowProductController.TabIndex = 0;
            btnShowProductController.UseVisualStyleBackColor = false;
            btnShowProductController.Click += EventShowProduct;
            btnShowProductController.MouseEnter += EnterShowPro;
            btnShowProductController.MouseLeave += LeaveShowPro;
            // 
            // panelControllerPage
            // 
            panelControllerPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControllerPage.AutoSize = true;
            panelControllerPage.Location = new Point(198, 88);
            panelControllerPage.Name = "panelControllerPage";
            panelControllerPage.Size = new Size(1065, 563);
            panelControllerPage.TabIndex = 4;
            // 
            // FormAboutProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 650);
            Controls.Add(panelControllerPage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAboutProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAboutProduct";
            panel_showTitleProduct.ResumeLayout(false);
            panel_showTitleProduct.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeleteController).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShortController).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddBtnController).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel_showTitleProduct;
        private Label labelInfoProduct;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnShowProductController;
        private PictureBox pictureBoxShowProduct;
        private Label labelShowProduct;
        private PictureBox pictureBoxDeleteController;
        private PictureBox pictureBoxShortController;
        private PictureBox pictureBoxAddBtnController;
        private Label labelDeleteController;
        private Label labelShortController;
        private Label labelAddControllerBtn;
        private Button btnDeleteController;
        private Button btnShortController;
        private Button btnAddController;
        private Panel panelControllerPage;
    }
}