

using SaleProductsManagerment.code;

namespace SaleProductsManagerment
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
            raduisPanel(this.panel_product);
            raduisPanel(this.panelHistoryProduct);
            raduisPanel(this.panelSaleProduct);
            raduisPanel(this.panelContactUs);
            raduisPanel(this.panelAboutUs);

        }

        private void click_event_about_product(object sender, EventArgs e)
        {
            FormAboutProduct page = new FormAboutProduct();
            page.Show(); 
        }

        private void mouse_enter_about_product(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panel_product, Color.SkyBlue);
        }

        private void mouse_leave_about_product(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panel_product, Color.Silver);
        }

        private void decoratorBackgroundColor(Panel panel, Color color)
        {
            panel.BackColor = color;
        }
        private void raduisPanel(Panel panel)
        {
            IntPtr value = NativeMethods.CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 10, 10);
            panel.Region = System.Drawing.Region.FromHrgn(value);
            NativeMethods.DeleteObject(value);
        }
        private void mouse_enter_about_us_product(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelAboutUs, Color.SkyBlue);
        }

        private void click_event_about_us_product(object sender, EventArgs e)
        {

        }

        private void mouse_leave_about_product_us(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelAboutUs, Color.Silver);
        }
        private void importProduct_event(object sender, EventArgs e)
        {

        }
        private void importproductEnter(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelSaleProduct, Color.SkyBlue);
        }

        private void ImportProductLeavEvent(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelSaleProduct, Color.Silver);
        }

        private void HistroryProduct_event(object sender, EventArgs e)
        {

        }

        private void HistoryproductEnter(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelHistoryProduct, Color.SkyBlue);
        }

        private void HistoryProductLeavEvent(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelHistoryProduct, Color.Silver);
        }

        private void click_even_ContactProduct(object sender, EventArgs e)
        {

        }

        private void mouse_enter_ContanctProduct(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelContactUs, Color.SkyBlue);
        }

        private void click_event_ContactProduct(object sender, EventArgs e)
        {
            decoratorBackgroundColor(this.panelContactUs, Color.Silver);
        }

        private void panel_product_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
