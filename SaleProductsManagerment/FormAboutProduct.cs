using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleProductsManagerment.code;

namespace SaleProductsManagerment
{
    public partial class FormAboutProduct : Form
    {
        public FormAboutProduct()
        {
            InitializeComponent();
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(0, 0, panel_showTitleProduct.Width, panel_showTitleProduct.Height, 30, 30);
            panel_showTitleProduct.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
            formShow(new ProductDisplays(), this.panelControllerPage);
        }

        private void EventShowProduct(object sender, EventArgs e)
        {
            formShow(new ProductDisplays(), this.panelControllerPage);
        }

        private void EnterShowPro(object sender, EventArgs e)
        {
            this.labelShowProduct.BackColor = Color.SkyBlue;
            this.pictureBoxShowProduct.BackColor = Color.SkyBlue;
            btnShowProductController.BackColor = Color.SkyBlue;


        }

        private void LeaveShowPro(object sender, EventArgs e)
        {
            this.labelShowProduct.BackColor = Color.White;
            this.pictureBoxShowProduct.BackColor = Color.White;
            btnShowProductController.BackColor = Color.White;
        }

        private void EventAddProduct(object sender, EventArgs e)
        {
            formShow(new AddControllProduct(), this.panelControllerPage);

        }

        private void EnterAddProduct(object sender, EventArgs e)
        {
            
            this.labelAddControllerBtn.BackColor = Color.SkyBlue;
            this.pictureBoxAddBtnController.BackColor = Color.SkyBlue;
            this.btnAddController.BackColor = Color.SkyBlue;
        }

        private void LeaveAddProduct(object sender, EventArgs e)
        {
            this.labelAddControllerBtn.BackColor = Color.White;
            this.pictureBoxAddBtnController.BackColor = Color.White;
            this.btnAddController.BackColor = Color.White;
        }

        private void SortEventProduct(object sender, EventArgs e)
        {
            formShow(new ProductDisplays(), this.panelControllerPage);
        }

        private void ShortEnterProduct(object sender, EventArgs e)
        {
            this.labelShortController.BackColor = Color.SkyBlue;
            this.pictureBoxShortController.BackColor = Color.SkyBlue;
            this.btnShortController.BackColor = Color.SkyBlue;
        }

        private void ShortLeaveProductEvent(object sender, EventArgs e)
        {

            this.labelShortController.BackColor = Color.White;
            this.pictureBoxShortController.BackColor = Color.White;
            this.btnShortController.BackColor = Color.White;
        }

        private void DeletClickEvent(object sender, EventArgs e)
        {
            formShow(new ProductDisplays(), this.panelControllerPage);
        }

        private void DeleteEnterProduct(object sender, EventArgs e)
        {
            this.labelDeleteController.BackColor = Color.SkyBlue;
            this.pictureBoxDeleteController.BackColor = Color.SkyBlue;
            this.btnDeleteController.BackColor = Color.SkyBlue;
        }

        private void DeleteLeaveEvent(object sender, EventArgs e)
        {
            this.labelDeleteController.BackColor = Color.White;
            this.pictureBoxDeleteController.BackColor = Color.White;
            this.btnDeleteController.BackColor = Color.White;
        }

        private void formShow(object form, Panel panel)

        {
            panel.Controls.Clear();
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel.Controls.Add(f);
            panel.Tag = f;
            f.Show();
        }

    }
}
