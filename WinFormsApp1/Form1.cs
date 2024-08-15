namespace LibraryManager
{
    public partial class Form1 : Form
    {
        private Library library;
        Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();
        public Form1()
        {
            InitializeComponent();
            library = new Library();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int year = int.Parse(YearTextBox.Text);
            string isbn = ISBNTextBox.Text;

            Book book = new Book(title, author, year, isbn);
            library.AddBook(book);

            MessageBox.Show("Book added successfully!");
        }
        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            // Get the selected item from the BooksListBox
            var selectedItem = BooksListBox.SelectedItem;

            if (selectedItem != null)
            {
                // Assuming Book.ToString() gives enough information to identify the book
                var selectedBook = selectedItem.ToString();

                // Find the corresponding book object in the library
                var bookToRemove = library.GetAllBooks().FirstOrDefault(b => b.ToString() == selectedBook);

                if (bookToRemove != null)
                {
                    // Remove the book from the library
                    library.RemoveBook(bookToRemove.ISBN);

                    // Update the BooksListBox
                    DisplayResults(library.GetAllBooks());
                }
            }
            else
            {
                MessageBox.Show("Please select a book to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowAllBooksButton_Click(object sender, EventArgs e)
        {
            BooksListBox.Items.Clear();

            var allBooks = library.GetAllBooks();
            foreach (var book in allBooks)
            {
                BooksListBox.Items.Add($"{book.Title} by {book.Author} ({book.Year}) - ISBN: {book.ISBN}");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.ToLower();
            var results = library.SearchBooks(query);
            DisplayResults(results);
        }
        private void DisplayResults(List<Book> books)
        {
            BooksListBox.Items.Clear(); // Clear existing items

            foreach (var book in books)
            {
                // Debugging to ensure the correct type is being added
                /*MessageBox.Show($"Adding item: {book}, Type: {book.GetType()}");*/

                BooksListBox.Items.Add(book); // Add Book objects directly
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var allBooks = library.GetAllBooks();
            DisplayResults(allBooks);
        }

        private void TitleTextBox_Enter(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "Title")
            {
                TitleTextBox.Text = "";

                TitleTextBox.ForeColor = Color.Black;
            }
        }

        private void TitleTextBox_Leave(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                TitleTextBox.Text = "Title";

                TitleTextBox.ForeColor = Color.Silver;
            }
        }

        private void AuthorTextBox_Enter(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "Author")
            {
                AuthorTextBox.Text = "";

                AuthorTextBox.ForeColor = Color.Black;
            }
        }

        private void AuthorTextBox_Leave(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorTextBox.Text = "Author";

                AuthorTextBox.ForeColor = Color.Silver;
            }
        }

        private void YearTextBox_Enter(object sender, EventArgs e)
        {
            if (YearTextBox.Text == "Year")
            {
                YearTextBox.Text = "";

                YearTextBox.ForeColor = Color.Black;
            }
        }

        private void YearTextBox_Leave(object sender, EventArgs e)
        {
            if (YearTextBox.Text == "")
            {
                YearTextBox.Text = "Year";

                YearTextBox.ForeColor = Color.Silver;
            }
        }

        private void ISBNTextBox_Enter(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text == "ISBN")
            {
                ISBNTextBox.Text = "";

                ISBNTextBox.ForeColor = Color.Black;
            }
        }

        private void ISBNTextBox_Leave(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text == "")
            {
                ISBNTextBox.Text = "ISBN";

                ISBNTextBox.ForeColor = Color.Silver;
            }
        }

        private void SaveBooksButton_Click(object sender, EventArgs e)
        {
            library.SaveLibrary();
        }
    }
}
