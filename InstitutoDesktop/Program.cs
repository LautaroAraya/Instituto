using InstitutoDesktop.Views.Commons;

namespace InstitutoDesktop
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

            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(DespliegueControladoDeErroresOtroshilos);

            //Application.ThreadException += new ThreadExceptionEventHandler(DespliegueControladoDeErroresHiloPrincipal);

            Application.Run(new MenuPrincipalView());
        }

        private static void DespliegueControladoDeErroresOtroshilos(object sender, UnhandledExceptionEventArgs args)
        {
            Exception exepcion = (Exception)args.ExceptionObject;

            // MessageBox.Show($"Ha ocurrido un error:{e.Message}{System.Environment.NewLine}Origen del error:{e.Source}");
            var errorView = new ErrorView(exepcion);
            errorView.ShowDialog();
        }

        private static void DespliegueControladoDeErroresHiloPrincipal(object sender, ThreadExceptionEventArgs e)
        {

            //MessageBox.Show($"Ha ocurrido un error:{e.Exception.Message}{System.Environment.NewLine}Origen del error:{e.Exception.Source}");
            var errorView = new ErrorView(e.Exception);
            errorView.ShowDialog();
        }
    }
}