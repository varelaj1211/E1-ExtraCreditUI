namespace E1ExtraCredit
{
    public delegate void UpdateLibrary();
    public delegate void SelectBookDel(int indx);
    public delegate string RemoveBookmarkDel(Book book);
    public delegate string SetBookmark(Book book);
    public delegate void GoToDel(int page, Book book);
    public delegate void PrevPageDel(Book book);
    public delegate void NextPageDel(Book book);
    
    
    public static class Program
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
            LibraryModel m = new LibraryModel();
            Controller controller = new Controller(m);
            //BookDetails bookDetails = new BookDetails()
            Application.Run(new Form1(m, controller.UpdateLibary, controller.SelectedBookHandler));
        }
    }
}