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
            if (model != null && model.books != null)
            {
                foreach (Book b in model.books)
                {
                    BookListViiew.Items.Add(new ListViewItem(b._title));
                }
            }
        }

        private void BookListViiew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListViiew.SelectedItems.Count > 0)
            {
                int index = BookListViiew.SelectedItems[0].Index;
                Book selectedBook = model.books[index];

                // Open the book details form
                BookDetails detailsForm = new BookDetails(selectedBook);
                detailsForm.ShowDialog(); // Show as a modal dialog
            }
        }
    }
}
