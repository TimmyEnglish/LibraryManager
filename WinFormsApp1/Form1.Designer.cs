namespace LibraryManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            YearTextBox = new TextBox();
            ISBNTextBox = new TextBox();
            AddBookButton = new Button();
            RemoveBookButton = new Button();
            ShowAllBooksButton = new Button();
            BooksListBox = new ListBox();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            SaveBooksButton = new Button();
            SuspendLayout();
            // 
            // TitleTextBox
            // 
            TitleTextBox.ForeColor = SystemColors.InactiveCaption;
            TitleTextBox.Location = new Point(28, 31);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(301, 31);
            TitleTextBox.TabIndex = 0;
            TitleTextBox.Text = "Title";
            TitleTextBox.Enter += TitleTextBox_Enter;
            TitleTextBox.Leave += TitleTextBox_Leave;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.ForeColor = SystemColors.InactiveCaption;
            AuthorTextBox.Location = new Point(28, 77);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(301, 31);
            AuthorTextBox.TabIndex = 1;
            AuthorTextBox.Text = "Author";
            AuthorTextBox.Enter += AuthorTextBox_Enter;
            AuthorTextBox.Leave += AuthorTextBox_Leave;
            // 
            // YearTextBox
            // 
            YearTextBox.ForeColor = SystemColors.InactiveCaption;
            YearTextBox.Location = new Point(28, 126);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(301, 31);
            YearTextBox.TabIndex = 2;
            YearTextBox.Text = "Year";
            YearTextBox.Enter += YearTextBox_Enter;
            YearTextBox.Leave += YearTextBox_Leave;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.ForeColor = SystemColors.InactiveCaption;
            ISBNTextBox.Location = new Point(28, 180);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(301, 31);
            ISBNTextBox.TabIndex = 3;
            ISBNTextBox.Text = "ISBN";
            ISBNTextBox.Enter += ISBNTextBox_Enter;
            ISBNTextBox.Leave += ISBNTextBox_Leave;
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.Gold;
            AddBookButton.FlatAppearance.BorderColor = Color.Black;
            AddBookButton.FlatStyle = FlatStyle.Flat;
            AddBookButton.Location = new Point(28, 245);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(142, 40);
            AddBookButton.TabIndex = 4;
            AddBookButton.Text = "Add Book";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // RemoveBookButton
            // 
            RemoveBookButton.BackColor = Color.Red;
            RemoveBookButton.FlatAppearance.BorderColor = Color.Black;
            RemoveBookButton.FlatStyle = FlatStyle.Flat;
            RemoveBookButton.Location = new Point(187, 245);
            RemoveBookButton.Name = "RemoveBookButton";
            RemoveBookButton.Size = new Size(142, 40);
            RemoveBookButton.TabIndex = 5;
            RemoveBookButton.Text = "Remove Book";
            RemoveBookButton.UseVisualStyleBackColor = false;
            RemoveBookButton.Click += RemoveBookButton_Click;
            // 
            // ShowAllBooksButton
            // 
            ShowAllBooksButton.BackColor = Color.DodgerBlue;
            ShowAllBooksButton.FlatAppearance.BorderColor = Color.Black;
            ShowAllBooksButton.FlatStyle = FlatStyle.Flat;
            ShowAllBooksButton.Location = new Point(111, 309);
            ShowAllBooksButton.Name = "ShowAllBooksButton";
            ShowAllBooksButton.Size = new Size(142, 40);
            ShowAllBooksButton.TabIndex = 8;
            ShowAllBooksButton.Text = "Show all books";
            ShowAllBooksButton.UseVisualStyleBackColor = false;
            ShowAllBooksButton.Click += ShowAllBooksButton_Click;
            // 
            // BooksListBox
            // 
            BooksListBox.FormattingEnabled = true;
            BooksListBox.ItemHeight = 25;
            BooksListBox.Location = new Point(365, 31);
            BooksListBox.Name = "BooksListBox";
            BooksListBox.Size = new Size(434, 629);
            BooksListBox.TabIndex = 9;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(28, 407);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(301, 31);
            SearchTextBox.TabIndex = 15;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.WhiteSmoke;
            SearchButton.FlatAppearance.BorderColor = Color.Black;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(111, 456);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(142, 40);
            SearchButton.TabIndex = 16;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SaveBooksButton
            // 
            SaveBooksButton.BackColor = Color.PaleGreen;
            SaveBooksButton.FlatAppearance.BorderColor = Color.Black;
            SaveBooksButton.FlatStyle = FlatStyle.Flat;
            SaveBooksButton.Location = new Point(111, 620);
            SaveBooksButton.Name = "SaveBooksButton";
            SaveBooksButton.Size = new Size(142, 40);
            SaveBooksButton.TabIndex = 17;
            SaveBooksButton.Text = "Save";
            SaveBooksButton.UseVisualStyleBackColor = false;
            SaveBooksButton.Click += SaveBooksButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 728);
            Controls.Add(SaveBooksButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(BooksListBox);
            Controls.Add(ShowAllBooksButton);
            Controls.Add(RemoveBookButton);
            Controls.Add(AddBookButton);
            Controls.Add(ISBNTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(TitleTextBox);
            Name = "Form1";
            Text = "Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleTextBox;
        private TextBox AuthorTextBox;
        private TextBox YearTextBox;
        private TextBox ISBNTextBox;
        private Button AddBookButton;
        private Button RemoveBookButton;
        private Button ShowAllBooksButton;
        private ListBox BooksListBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button SaveBooksButton;
    }
}
