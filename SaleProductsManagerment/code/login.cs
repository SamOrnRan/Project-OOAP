using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SaleProductsManagerment.code
{
    public class Login
    {
        private string UserName​;
        private string Password;


        public string _userName
        {
            set { this.UserName = value; }
            get { return this.UserName; }
        }
        public string _password {
            set { this.Password = value; }
            get { return this.Password; }
           

        }

    }
      public  class HandleControllerChekcFalse : Login
    {
        
    public  string checkName(string user ,string pwd)
        {
             if (user != "") return this._userName= "Invalide";    
           if (pwd != "") return this._password= "Invalide"; 
            return "";
        }
  }

}
