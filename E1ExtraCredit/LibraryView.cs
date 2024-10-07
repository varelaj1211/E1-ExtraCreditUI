namespace E1ExtraCredit
{
    public partial class LibraryView : Form
    {
        
        private LibraryModel model;
        private SelectBookDel SelectBookDel;
        private SyncLibDel SyncLibDel;
        private Status state;
        public LibraryView(LibraryModel m, SyncLibDel syncLib, SelectBookDel selectBook)//, string serialNum)
        {
            InitializeComponent();
            model = m;
            this.SyncLibDel = syncLib;
            this.SelectBookDel = selectBook;
            AddListToListView();
        }

        

        private void SyncButtonClick(object sender, EventArgs e)
        {

            SyncLibDel(model.books);
            

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

       

        public void UpdateLibraryView(Status s)
        {
            state = s;
            switch (state)
            {
                case Status.Sync:
                    MessageBox.Show("Synchrozing Libraries");
                    AddListToListView();
                    SyncButton.Enabled = false;
                    break;

                case Status.SelectBook:
                    MessageBox.Show("You have selected a book");
                    break;

            }

        }

        
    }
}
