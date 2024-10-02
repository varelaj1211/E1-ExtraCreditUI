namespace E1ExtraCredit
{
    public partial class Form1 : Form
    {
        public Form1(LibraryModel m)//, string serialNum)
        {
            InitializeComponent();
            AddListToListView();
        }

        private void SyncButtonClick(object sender, EventArgs e)
        {
            Book Book4 = new Book()
            {
                _page = 832,
                _title = "The Shining ",
                _author = "Stephen King ",
                _serialNumber = "3768925630"
            };

            Book Book5 = new Book()
            {
                _page = 283,
                _title = "Hunger Games ",
                _author = "Suzanne Collins ",
                _serialNumber = "3567650928"
            };
            model.AddBook(Book4);
            model.AddBook(Book5);
            AddListToListView();
        }

        private void UpdateLibrary(List<string> books)
        {

        }

        public LibraryModel model;
        public void AddListToListView()
        {
            BookListViiew.Items.Clear();
            foreach(Book b in model.books) 
            {
                BookListViiew.Items.Add(b._title);
            }
        }
    }
}
