namespace E1ExtraCredit
{
    public partial class Form1 : Form
    {
        public Form1(LibraryModel m)//, string serialNum)
        {
            InitializeComponent();
            model = m;
            AddListToListView();
        }

        private void SyncButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Synchrozing Libraries");
            Book Book4 = new Book()
            {
                Page = 832,
                Title = "The Shining ",
                Author = "Stephen King ",
                SerialNumber = "3768925630"
            };

            Book Book5 = new Book()
            {
                Page = 283,
                Title = "Hunger Games ",
                Author = "Suzanne Collins ",
                SerialNumber = "3567650928"
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
                    BookListViiew.Items.Add(new ListViewItem(b.Title));
                }
            }
        }

        private void BookListViiew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListViiew.SelectedItems.Count > 0)
            {
                int index = BookListViiew.SelectedItems[0].Index;
                Book selectedBook = model.books[index];

              
                BookDetails detailsForm = new BookDetails(selectedBook);
                detailsForm.ShowDialog(); 
            }
        }
    }
}
