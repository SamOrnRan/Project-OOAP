using SaleProductsManagerment.code;

namespace SaleProductsManagerment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         if (ChangeApplication.value == false)
           {
             Application.Run(new LognIn());
           }
           if(ChangeApplication.value == true)
           {
           Application.Run(new FormDashBoard());
           }


   //     Application.Run(new FormAboutProduct());
        }
    }
}