namespace ATIVIDADE_POO_12112021_GIANPIEROGIGLIO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CadastroAlunos());
        }
    }
}