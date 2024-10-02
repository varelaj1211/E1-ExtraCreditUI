namespace E1ExtraCredit
{
    public partial class Form1 : Form
    {
        public Form1(LibraryModel m, string serialNum)
        {
            InitializeComponent();
            AddListToListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateLibrary(List<string> books)
        {

        }

        public LibraryModel model;
        public void AddListToListView()
        {
            foreach(Book b in model.books) 
            {
                BookListViiew.Items.Add(b._title);
            }
        }
    }
}
