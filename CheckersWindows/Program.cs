namespace CheckersWindows
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
            GameManager gameManager = new GameManager();
            Application.Run(new Form1(gameManager));
            Application.Run(new Form2(gameManager));
            

        }
    }
}