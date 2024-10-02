namespace E1ExtraCredit
{
    public static class Program
    {

        public delegate void UpdateLibrary(List<string> books);
        public delegate void SelectBookDel(string serialNum);
        
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
        }
    }
}