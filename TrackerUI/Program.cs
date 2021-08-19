namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// Začátek aplikace. Vízejte v Tournament trackeru!
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializace spojení s databází a txt uložištěm.
            string currentPath = Directory.GetCurrentDirectory();
            string TextFilesPath = $@"{currentPath}\Data";
            Directory.CreateDirectory(TextFilesPath);
            GlobalConfig.InitializeConnections(DatabaseType.Sql);

            Application.Run(new TournamentDashboardForm());
        }
    }
}
