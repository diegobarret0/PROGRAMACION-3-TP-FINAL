using PROGRAMACION_3_TP_FINAL.Services;

namespace PROGRAMACION_3_TP_FINAL
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
            Application.Run(new Form1());
            //HoursAndCostValidation validations = new HoursAndCostValidation(1);
            //MessageBox.Show(validations.validateHours().ToString());
        }
    }
}