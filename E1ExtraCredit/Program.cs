namespace E1ExtraCredit
{
    public delegate void UpdateLibrary(Status s);
    public delegate void SyncLibDel(List<Book> books);
    public delegate void SelectBookDel(int indx);
    public delegate void RemoveBookmarkDel(Book book, List<int> pagesList);
    public delegate void SetBookmark(Book book, List<int> pagesList);
    public delegate void GoToDel(int page, Book book);
    public delegate void PrevPageDel(Book book);
    public delegate void NextPageDel(Book book);
    public delegate void UpdateViewState(Status s);
    
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
            LibraryView libView = new LibraryView(m, controller.SyncLibaryHandler, controller.SelectedBookHandler);
            //BookDetails details = new BookDetails(m, 2, controller.NextPgHandler, controller.PrevPgHandler, controller.RemoveBMHandler, controller.SelectBMHandler, controller.GoToPgHandler);
            
            controller.RegisterLibaryObserver(libView.UpdateLibraryView);
            //controller.RegisterDetailsObserver(details.UpdateGameState);
            Application.Run(libView);
        }
    }
}