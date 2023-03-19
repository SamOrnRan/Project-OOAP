using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleProductsManagerment
{
    public partial class ProductDisplays : Form
    {
        BindingSource bn = new BindingSource();
        DataTable table = new DataTable();
        public ProductDisplays()
        {
            InitializeComponent();
            table.Columns.Add("លេខសម្គាល់ទំនិញ", typeof(string));
            table.Columns.Add("ឈ្មោះទំនិញ", typeof(string));
            table.Columns.Add("ចំនួនទំនិញ", typeof(string));
            table.Columns.Add("តម្លៃទំនិញ", typeof(string));
            table.Columns.Add("ការពិពណ៌នាអំពីទំនិញ", typeof(string));
            table.Rows.Add("AADDD", "BBBBBDD", "CCCDD", "DDDDDC", "AAADD#D");
            bn.DataSource = table;
            dataGrid.DataSource = bn;
            bn.ResetBindings(false);
        }
    }
}
