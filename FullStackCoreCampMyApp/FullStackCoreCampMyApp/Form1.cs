namespace FullStackCoreCampMyApp
{
    public partial class Form1 : Form
    {
        private Book selectedBook = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Books;
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBook.Text))
            {
                Book addedBook = new Book();
                addedBook.Title = txtBook.Text;

                var lastNote = DataStore.Books[DataStore.Books.Count - 1];
                addedBook.Id = lastNote.Id + 1;

                DataStore.Books.Add(addedBook);
                Refresh();
            }
            else
            {
                MessageBox.Show("Kitap baþlýðýný giriniz");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedBook = (Book)listBox1.SelectedItem;
                txtBook.Text = selectedBook.Title;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataStore.Books.Remove(selectedBook);
            selectedBook = null;
            txtBook.Text = string.Empty;
            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBook.Text))
            {
                selectedBook.Title = txtBook.Text;
                Refresh();
            }
            else
            {
                MessageBox.Show("Düzenlenecek kitap seçiniz");
            }
        }
    }
}