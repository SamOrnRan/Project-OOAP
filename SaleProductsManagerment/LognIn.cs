using System.Windows.Forms.VisualStyles;
using SaleProductsManagerment.code;

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
            // កំណត់តម្លៃដំបូន នៅពេលចាប់ផ្តើម open form   or Initialize ​
            // ផ្លល់តម្លៃបែបនេះ ដើម្បី៎គូរឲ្យ បាននៃform login នៃ form មានរាងកោង តាមជ្រុងនីមួយ
            panel_container.BackColor = Color.FromArgb(180, 10, 10, 10);
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, this.panel_container.Width, this.panel_container.Height, 20, 20);
            this.panel_container.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

        }
        private void btn_login_event(object sender, EventArgs e)
        {

            // HandleControllerChekcProcessing    គឺជា class មួយដែលប្រើជាមួយ   Chain of Responsibility Pattern 
            // ក្នុងគោកបំណង  responce នៅពេលត្រួតពិនិត្យ  Form ​មានបញ្ហាអ្វីមួយ វានិង​​  return ដោយការធ្វើសំណើរ តាមរយៈbutton
            HandleControllerChekcProcessing chekcProccess =  new HandleControllerChekcProcessing(this.user_name_controller.Text, psw_controller.Text);
            btn_logIncontroller.BackColor = Color.Green;
            pwd_check_label.Text = chekcProccess.passwordController().ToString();
            username_check_label.Text = chekcProccess.userNameController().ToString();
            if (chekcProccess.onRequestSucces().Equals("yes"))
            { 
                //  វានិងផ្ផ្លាស់ប្តូរ form នៅពេល ChangeApplication.value ពិត​ 
                // បន្ទាប់មក វានិង  បង្ហាញ  Dashboard Form ​
                // អាចពិនិត្យនៅ ក្នុង file program.cs
                ChangeApplication.value = true; 
                this.Close();
            }
        }
        private void btn_login_enter_event(object sender, EventArgs e)
        {
             // នៅពេលយើងដាក់ mouse ចូលទៅក្នុង button login វានិងផ្លាស់ប្តូពណ៍
            btn_logIncontroller.BackColor = Color.Silver;
        }

        private void btnlogin_leave_event(object sender, EventArgs e)
        {
            // នៅពេលយើងដក់ mouse ចេញពី button login វានិងផ្លាស់ប្តូពណ៍

            btn_logIncontroller.BackColor = Color.White;


        }

        private void close_event(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}