namespace SaleProductsManagerment
{
    partial class LognIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LognIn));
            panelBakcgroundColor = new Panel();
            btn_close = new Button();
            panel_container = new Panel();
            username_check_label = new Label();
            pwd_check_label = new Label();
            label2 = new Label();
            password_label = new Label();
            label_user_name = new Label();
            psw_controller = new TextBox();
            user_name_controller = new TextBox();
            btn_logIncontroller = new Button();
            label1 = new Label();
            panelBakcgroundColor.SuspendLayout();
            panel_container.SuspendLayout();
            SuspendLayout();
            // 
            // panelBakcgroundColor
            // 
            panelBakcgroundColor.BackColor = Color.Transparent;
            panelBakcgroundColor.BackgroundImageLayout = ImageLayout.None;
            panelBakcgroundColor.BorderStyle = BorderStyle.FixedSingle;
            panelBakcgroundColor.Controls.Add(btn_close);
            panelBakcgroundColor.Controls.Add(panel_container);
            panelBakcgroundColor.Location = new Point(0, 0);
            panelBakcgroundColor.Name = "panelBakcgroundColor";
            panelBakcgroundColor.Size = new Size(783, 558);
            panelBakcgroundColor.TabIndex = 0;
            panelBakcgroundColor.Paint += panelBakcgroundColor_Paint;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Location = new Point(736, 10);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(34, 34);
            btn_close.TabIndex = 1;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += close_event;
            // 
            // panel_container
            // 
            panel_container.BackColor = Color.DimGray;
            panel_container.Controls.Add(username_check_label);
            panel_container.Controls.Add(pwd_check_label);
            panel_container.Controls.Add(label2);
            panel_container.Controls.Add(password_label);
            panel_container.Controls.Add(label_user_name);
            panel_container.Controls.Add(psw_controller);
            panel_container.Controls.Add(user_name_controller);
            panel_container.Controls.Add(btn_logIncontroller);
            panel_container.Controls.Add(label1);
            panel_container.Location = new Point(217, 47);
            panel_container.Name = "panel_container";
            panel_container.Size = new Size(365, 465);
            panel_container.TabIndex = 0;
            panel_container.Paint += panel1_Paint;
            // 
            // username_check_label
            // 
            username_check_label.AutoSize = true;
            username_check_label.BackColor = Color.Transparent;
            username_check_label.ForeColor = Color.Red;
            username_check_label.Location = new Point(67, 163);
            username_check_label.Name = "username_check_label";
            username_check_label.Size = new Size(0, 17);
            username_check_label.TabIndex = 101;
            // 
            // pwd_check_label
            // 
            pwd_check_label.AutoSize = true;
            pwd_check_label.BackColor = Color.Transparent;
            pwd_check_label.ForeColor = Color.Red;
            pwd_check_label.Location = new Point(67, 236);
            pwd_check_label.Name = "pwd_check_label";
            pwd_check_label.Size = new Size(0, 17);
            pwd_check_label.TabIndex = 101;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.0934572F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(24, 347);
            label2.Name = "label2";
            label2.Size = new Size(319, 91);
            label2.TabIndex = 100;
            label2.Text = "By using our services, you agree to accept our Term and Condition and Privacy Policy.\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Segoe UI", 10.0934572F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.ForeColor = Color.Gold;
            password_label.Location = new Point(65, 183);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // label_user_name
            // 
            label_user_name.AutoSize = true;
            label_user_name.BackColor = Color.Transparent;
            label_user_name.Font = new Font("Segoe UI", 10.0934572F, FontStyle.Regular, GraphicsUnit.Point);
            label_user_name.ForeColor = Color.Gold;
            label_user_name.Location = new Point(65, 108);
            label_user_name.Name = "label_user_name";
            label_user_name.Size = new Size(82, 20);
            label_user_name.TabIndex = 5;
            label_user_name.Text = "User Name";
            // 
            // psw_controller
            // 
            psw_controller.BackColor = SystemColors.InactiveCaption;
            psw_controller.Font = new Font("Segoe UI", 10.7663546F, FontStyle.Regular, GraphicsUnit.Point);
            psw_controller.Location = new Point(65, 204);
            psw_controller.Name = "psw_controller";
            psw_controller.Size = new Size(244, 29);
            psw_controller.TabIndex = 4;
            // 
            // user_name_controller
            // 
            user_name_controller.BackColor = SystemColors.InactiveCaption;
            user_name_controller.Font = new Font("Segoe UI", 10.7663546F, FontStyle.Regular, GraphicsUnit.Point);
            user_name_controller.Location = new Point(65, 131);
            user_name_controller.Name = "user_name_controller";
            user_name_controller.Size = new Size(244, 29);
            user_name_controller.TabIndex = 4;
            // 
            // btn_logIncontroller
            // 
            btn_logIncontroller.Font = new Font("Segoe UI", 12.1121492F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logIncontroller.ForeColor = Color.DarkBlue;
            btn_logIncontroller.Location = new Point(79, 273);
            btn_logIncontroller.Name = "btn_logIncontroller";
            btn_logIncontroller.Size = new Size(213, 41);
            btn_logIncontroller.TabIndex = 3;
            btn_logIncontroller.Text = "Log In";
            btn_logIncontroller.UseVisualStyleBackColor = true;
            btn_logIncontroller.Click += btn_login_event;
            btn_logIncontroller.MouseEnter += btn_login_enter_event;
            btn_logIncontroller.MouseLeave += btnlogin_leave_event;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Khmer OS Muol Pali", 14.13084F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(134, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 47);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // LognIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 558);
            Controls.Add(panelBakcgroundColor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LognIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelBakcgroundColor.ResumeLayout(false);
            panel_container.ResumeLayout(false);
            panel_container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBakcgroundColor;
        private Panel panel_container;
        private Label label1;
        private Button btn_logIncontroller;
        private TextBox psw_controller;
        private TextBox user_name_controller;
        private Label password_label;
        private Label label_user_name;
        private Label label2;
        private Label username_check_label;
        private Label pwd_check_label;
        private Button btn_close;
    }
}