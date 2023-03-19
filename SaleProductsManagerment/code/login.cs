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
        public string onRequestSucces()
        {
            if (_userName == "Admin" && _password == "123456")
                return "yes";
            return "no";

        }

    }
     public class HandleControllerChekcProcessing : Login
    {


        public HandleControllerChekcProcessing(string user, string pwd)
        {
            this._userName = user;
            this._password = pwd;
        }
        public string userNameController()
        {
            if (_userName == "Admin") return "";
            if (this._userName!="") return "Invalide"; 

            if (this._userName=="") return "Please input username";  
            return ""; 
        }
        public string passwordController() {
            string value = "";
            if (this._password =="123456")return  ""; 
            if (this._password=="")value=  "Please input  Password";
            if (this._password!="")value = "Invalide";
            return value;

        }
       

    }



}
