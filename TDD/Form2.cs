using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TDD
{
    public partial class ISBN : Form
    {
        public ISBN()
        {
            InitializeComponent();
        }

        public void LoadBooks(List<Book> books)
        {
        
            var sortedBooks = books.OrderBy(b => b.PublishYear).ToList();

           
            dataGridView1.DataSource = sortedBooks.Select(b => new
            {
                b.ISBN,
                b.Name,
                b.Author,
                b.PublishYear,
                b.Category,
                Status = b.IsBorrowed ? "Borrowed" : "Available"
            }).ToList();

            
            double averagePublishYear = sortedBooks.Average(b => b.PublishYear);
            
            int totalBooks = sortedBooks.Count;
           
            int availableBooks = sortedBooks.Count(b => !b.IsBorrowed);

            
            MessageBox.Show($"Average Publish Year: {averagePublishYear}\nTotal Books: {totalBooks}\nAvailable Books: {availableBooks}", "Book Statistics");
        }

        private void ISBN_Load(object sender, EventArgs e)
        {
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

   
}
