using ApplicationService.Services.Interface;
using Ninject;
using View.Configuration;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel ninjectKernel = new StandardKernel();
            DiContainer.RegisterServices(ninjectKernel);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(ninjectKernel.Get<IProductService>(), ninjectKernel.Get<ICustomerService>()));
        }
    }
}