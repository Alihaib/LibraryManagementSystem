using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Catorgy.KeyPress += Catorgy_KeyPress;
            QStatus.KeyPress += QStatus_KeyPress;
            ISBN.KeyPress += ISBN_KeyPress;
            PublichYear.KeyPress += PublichYear_KeyPress;
            BookName.KeyPress += BookName_KeyPress;
            AutherName.KeyPress += AutherName_KeyPress;
        }

        private void Addbooks_Click(object sender, EventArgs e)
        {
            GenerateBooks();
            MessageBox.Show("10,000 books generated successfully!");
        }

        public void GenerateBooks()
        {
            var random = new Random();
            var categories = new[] { "Science Fiction", "Romance", "History", "Biography" };
            var bookNames = new[] { "Book1", "Book2", "Book3" };
            var authorNames = new[] { "Author1", "Author2", "Author3" };

            for (int i = 0; i < 10000; i++)
            {
                var book = new Book
                {
                    ISBN = random.Next(1000000, 9999999).ToString(),
                    Name = bookNames[random.Next(bookNames.Length)],
                    Author = authorNames[random.Next(authorNames.Length)],
                    PublishYear = random.Next(1900, 2024), 
                    Category = categories[random.Next(categories.Length)],
                    IsBorrowed = random.Next(2) == 1
                };
                books.Add(book);
            }
        }

        private void Insertbook_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(ISBN.Text) ||
                    string.IsNullOrWhiteSpace(BookName.Text) ||
                    string.IsNullOrWhiteSpace(AutherName.Text) ||
                    string.IsNullOrWhiteSpace(PublichYear.Text) ||
                    string.IsNullOrWhiteSpace(Catorgy.Text) ||
                    string.IsNullOrWhiteSpace(QStatus.Text))
                {
                    MessageBox.Show("All fields must be filled out.");
                    return;
                }

                
                if (!int.TryParse(PublichYear.Text, out int publishYear) || publishYear <= 1900 || publishYear >= 2024)
                {
                    MessageBox.Show("Publish year must be between 1900 and 2024.");
                    return;
                }

             
                Debug.WriteLine($"ISBN: {ISBN.Text}");
                Debug.WriteLine($"Book Name: {BookName.Text}");
                Debug.WriteLine($"Author: {AutherName.Text}");
                Debug.WriteLine($"Publish Year: {publishYear}");
                Debug.WriteLine($"Category: {Catorgy.Text}");
                Debug.WriteLine($"Question Status: {QStatus.Text}");

                
                var book = new Book
                {
                    ISBN = ISBN.Text,
                    Name = BookName.Text,
                    Author = AutherName.Text,
                    PublishYear = publishYear,
                    Category = Catorgy.Text,
                    IsBorrowed = QStatus.Text == "Borrowed"
                };

                AddBook(book);
                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }


        public void AddBook(Book book)
        {
            books.Add(book);
        }

        private async void Bookslist_Click(object sender, EventArgs e)
        {
            var report = await Task.Run(() => GenerateReport());

            ISBN isbnForm = new ISBN();
            isbnForm.LoadBooks(books);
            isbnForm.Show();
        }


        public string GenerateReport()
        {
            // מסנן את הרשימה כדי לקבל את הספרים לפי שנה
            var sortedBooks = QuicksortBooksByPublishYear(books);

            // חישוב מספר הספרים הכולל
            int totalBooks = sortedBooks.Count;

            // חישוב ממוצע שנת הפרסום
            double averageYear = totalBooks > 0 ? sortedBooks.Average(book => book.PublishYear) : 0.0;

            // חישוב מספר הספרים הזמינים להשאלה
            int availableBooks = sortedBooks.Count(book => !book.IsBorrowed);

            // יצירת התוכן של הדו"ח
            string report = $"Total Books: {totalBooks}\n" +
                            $"Average Publish Year: {averageYear:F2}\n" +
                            $"Available Books: {availableBooks}\n";

            // הוספת פרטי הספרים
            report += "Books:\n";
            foreach (var book in sortedBooks)
            {
                report += $"{book.ISBN}, {book.Name}, {book.Author}, {book.PublishYear}, {book.Category}, {(book.IsBorrowed ? "Borrowed" : "Available")}\n";
            }

            return report;
        }


        public List<Book> QuicksortBooksByPublishYear(List<Book> bookList)
        {
            var stopwatch = Stopwatch.StartNew();
            List<Book> sortedBooks = Quicksort(bookList);
            stopwatch.Stop();
            MessageBox.Show($"Quicksort took {stopwatch.ElapsedMilliseconds} ms");

            return sortedBooks;
        }
        /*
        public List<Book> BubbleSortBooksByPublishYear(List<Book> bookList)
        {
            int n = bookList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (bookList[j].PublishYear < bookList[j + 1].PublishYear)
                    {
                        var temp = bookList[j];
                        bookList[j] = bookList[j + 1];
                        bookList[j + 1] = temp;
                    }
                }
            }
            return bookList;
        }
        */

        private List<Book> Quicksort(List<Book> books)
        {
            if (books.Count <= 1)
                return books;

            var pivot = books[books.Count / 2];
            var less = books.Where(book => book.PublishYear < pivot.PublishYear).ToList();
            var equal = books.Where(book => book.PublishYear == pivot.PublishYear).ToList();
            var greater = books.Where(book => book.PublishYear > pivot.PublishYear).ToList();

            return Quicksort(less).Concat(equal).Concat(Quicksort(greater)).ToList();
        }

        public int GetBookCount()
        {
            return books.Count;
        }

        private void ISBN_TextChanged(object sender, EventArgs e) { }
        private void BookName_TextChanged(object sender, EventArgs e) { }
        private void AutherName_TextChanged(object sender, EventArgs e) { }
        private void PublichYear_TextChanged(object sender, EventArgs e) { }
        private void Catorgy_TextChanged(object sender, EventArgs e) { }
        private void QStatus_TextChanged(object sender, EventArgs e) { }
        private void ISBN1_TextChanged(object sender, EventArgs e) { }
        private void BookName1_TextChanged(object sender, EventArgs e) { }
        private void AutherName1_TextChanged(object sender, EventArgs e) { }
        private void PublichYear1_TextChanged(object sender, EventArgs e) { }
        private void Catorgy1_TextChanged(object sender, EventArgs e) { }
        private void QStatus1_TextChanged(object sender, EventArgs e) { }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }

        private void ISBN_Enter(object sender, EventArgs e)
        {
            if (ISBN.Text == "ISBN:")
            {
                ISBN.Text = "";
            }
            ISBN.ForeColor = Color.Black;
        }

        private void ISBN_Leave(object sender, EventArgs e)
        {
            if (ISBN.Text == "")
            {
                ISBN.Text = "ISBN:";
            }
            ISBN.ForeColor = Color.Black;
        }

        private void BookName_Enter(object sender, EventArgs e)
        {
            if (BookName.Text == "Book Name:")
            {
                BookName.Text = "";
            }
            BookName.ForeColor = Color.Black;
        }

        private void BookName_Leave(object sender, EventArgs e)
        {
            if (BookName.Text == "")
            {
                BookName.Text = "Book Name:";
            }
            BookName.ForeColor = Color.Black;
        }

        private void AutherName_Enter(object sender, EventArgs e)
        {
            if (AutherName.Text == "Authur's Name:")
            {
                AutherName.Text = "";
            }
            AutherName.ForeColor = Color.Black;
        }

        private void AutherName_Leave(object sender, EventArgs e)
        {
            if (AutherName.Text == "")
            {
                AutherName.Text = "Authur's Name:";
            }
            AutherName.ForeColor = Color.Black;
        }

        private void PublichYear_Enter(object sender, EventArgs e)
        {
            if (PublichYear.Text == "Publish Year:")
            {
                PublichYear.Text = "";
            }
            PublichYear.ForeColor = Color.Black;
        }

        private void PublichYear_Leave(object sender, EventArgs e)
        {
            if (PublichYear.Text == "")
            {
                PublichYear.Text = "Publish Year:";
            }
            PublichYear.ForeColor = Color.Black;
        }

        private void Catorgy_Enter(object sender, EventArgs e)
        {
            if (Catorgy.Text == "Category:")
            {
                Catorgy.Text = "";
            }
            Catorgy.ForeColor = Color.Black;
        }

        private void Catorgy_Leave(object sender, EventArgs e)
        {
            if (Catorgy.Text == "")
            {
                Catorgy.Text = "Category:";
            }
            Catorgy.ForeColor = Color.Black;
        }

        private void QStatus_Enter(object sender, EventArgs e)
        {
            if (QStatus.Text == "Question Status:")
            {
                QStatus.Text = "";
            }
            QStatus.ForeColor = Color.Black;
        }

        private void QStatus_Leave(object sender, EventArgs e)
        {
            if (QStatus.Text == "")
            {
                QStatus.Text = "Question Status:";
            }
            QStatus.ForeColor = Color.Black;
        }

        private void Catorgy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Numbers are not allowed in the Category field.");
                e.Handled = true;
            }
        }

        private void QStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Numbers are not allowed in the Question Status field.");
                e.Handled = true;
            }
        }

        private void ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed in the ISBN field.");
                e.Handled = true;
            }
        }

        private void PublichYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed in the Publish Year field.");
                e.Handled = true;
            }
        }

        private void BookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Numbers are not allowed in the Book Name field.");
                e.Handled = true;
            }
        }

        private void AutherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Numbers are not allowed in the Author's Name field.");
                e.Handled = true;
            }
        }
    }

    public class Book
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }
        public string Category { get; set; }
        public bool IsBorrowed { get; set; }
    }
}