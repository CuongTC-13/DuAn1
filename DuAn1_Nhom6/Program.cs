

using DuAn1_Nhom6.DomainClass;

namespace DuAn1_Nhom6
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
            Application.Run(new LoginAdmin());
            //Scaffold-DbContext 'Data Source=LAPTOP-K5I0S8PT;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
        }
    }
}