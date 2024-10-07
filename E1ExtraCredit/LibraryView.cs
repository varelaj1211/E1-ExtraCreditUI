namespace E1ExtraCredit
{
    public partial class LibraryView : Form
    {
        private UpdateLibrary UpdateLib;
        private LibraryModel model;
        private SelectBookDel SelectBookDel;
        public LibraryView(LibraryModel m, UpdateLibrary updateLib, SelectBookDel selectBook)//, string serialNum)
        {
            InitializeComponent();
            model = m;
            this.UpdateLib = updateLib;
            this.SelectBookDel = selectBook;
            AddListToListView();
        }

        pr

        private void SyncButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Synchrozing Libraries");
            UpdateLib();
            AddListToListView();

        }

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

                SelectBookDel(index);

            }
        }
    }
}
