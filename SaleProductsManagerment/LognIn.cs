using System.Windows.Forms.VisualStyles;

namespace SaleProductsManagerment
{
    public partial class LognIn : Form
    {
        public LognIn()
        {
            InitializeComponent();
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
            this.username_check_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.pwd_check_label.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void panelBakcgroundColor_Paint(object sender, PaintEventArgs e)
        {
            this.panelBakcgroundColor.BackColor = Color.FromArgb(70, 0, 0, 0);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel_container.BackColor = Color.FromArgb(180, 10, 10, 10);
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, this.panel_container.Width, this.panel_container.Height, 20, 20);
            this.panel_container.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

        }

        private void btn_login_event(object sender, EventArgs e)
        {
            btn_logIncontroller.BackColor = Color.Green;
            if (user_name_controller.Text == "")
            {

                //  checkForm("Please input User Name");
                username_check_label.Text = "Please input your user name";


            }
            if (psw_controller.Text == "")
            {
                pwd_check_label.Text = "Please input your password";
            }

            else if (user_name_controller.Text != "")
            {
                username_check_label.Text = checkForm();
            }
            else if (psw_controller.Text != "")
            {
                pwd_check_label.Text = "Invalide";
            }

            if (user_name_controller.Text == "Admin")
            {
                username_check_label.Text = "";

            }
            if (psw_controller.Text == "123456")
            {
                pwd_check_label.Text = "";
            }
            if (user_name_controller.Text == "Admin" && psw_controller.Text == "123456")
            {
                username_check_label.Text = "";
                pwd_check_label.Text = "";
                ChangeApplication.value = true;
                this.Close();

            }
        }

        private void btn_login_enter_event(object sender, EventArgs e)
        {
            btn_logIncontroller.BackColor = Color.Silver;
        }

        private void btnlogin_leave_event(object sender, EventArgs e)
        {
            btn_logIncontroller.BackColor = Color.White;

        }

        private string checkForm()
        {



            return "Invalid";
        }

        private void close_event(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}