namespace GameMoes_00
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// --------------------------------------
            /// SET ME TO FALSE TO GET NO LOG WINDOW
            bool Debug = true;
            /// --------------------------------------

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (Debug) Application.Run(new DebugLogWindow());
            else Application.Run(new Game());
        }
    }
}