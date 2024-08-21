using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TDD;

namespace TDDTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddBook()
        {
            var form = new Form1();
            var initialBookCount = form.GetBookCount();

            var newBook = new Book
            {
                ISBN = "1234567",
                Name = "Test Book",
                Author = "Test Author",
                PublishYear = 2020,
                Category = "Test",
                IsBorrowed = false
            };

            form.AddBook(newBook);
            var finalBookCount = form.GetBookCount();

            Assert.AreEqual(initialBookCount + 1, finalBookCount);
        }

        [TestMethod]
        public void TestGenerateBooks()
        {
            var form = new Form1();

            form.GenerateBooks();
            var bookCount = form.GetBookCount();

            Assert.AreEqual(10000, bookCount);
        }

        [TestMethod]
        public void TestQuicksortBooksByPublishYear()
        {
            var form = new Form1();
            var unsortedBooks = new List<Book>
            {
                new Book { ISBN = "1", Name = "Book1", PublishYear = 2020 },
                new Book { ISBN = "2", Name = "Book2", PublishYear = 2019 },
                new Book { ISBN = "3", Name = "Book3", PublishYear = 2021 },
            };
            var expectedOrder = unsortedBooks.OrderBy(b => b.PublishYear).ToList();

            var sortedBooks = form.QuicksortBooksByPublishYear(unsortedBooks);

            CollectionAssert.AreEqual(expectedOrder, sortedBooks);
        }

        [TestMethod]
        public void TestGenerateReport()
        {
            var form = new Form1();
            var book = new Book
            {
                ISBN = "1234567",
                Name = "Test Book",
                Author = "Test Author",
                PublishYear = 2020,
                Category = "Test",
                IsBorrowed = false
            };

            form.AddBook(book);

            var report = form.GenerateReport();

            Assert.IsTrue(report.Contains("Total Books: 1"));
            Assert.IsTrue(report.Contains("Average Publish Year: 2020.00"));
            Assert.IsTrue(report.Contains("Available Books: 1"));
        }
    }
}
