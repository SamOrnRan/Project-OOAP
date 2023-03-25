
namespace SaleProductsManagerment.code
{
     public interface ComponentProduct
    {
        public int deleteProduct(int index);
        public void diplayProduct();

    } 
    public class Product : ComponentProduct
    {

        public  string _proName { get; set; }
        public string _price { get; set; }   
        public string _Description { get; set; }   
        public string _qty { get; set; }   

        public Product(string name,string qty, string price, string des)
        {
            this._proName = name;  
            this._price = price;
            this._qty = qty;
            this._Description = des;
        }

        
        
     public  int deleteProduct(int index)
        {
            return 0; 
        }
        public void diplayProduct() { }
        
    }    
    public  class HistoryProduct : ComponentProduct
    {
    public int deleteProduct(int index)
        {
            return 0;
        }
        public void diplayProduct() { }
    }
    public class ProductSaleOut : ComponentProduct
    { public int deleteProduct(int index)
        {
            return 0;
        }
        public void diplayProduct() { } 
    }
   
}
