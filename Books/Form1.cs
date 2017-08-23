using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Form1 : Form
    {
        struct Book
        {
            private string _ISBN;
            private string _title;
            private int _year;

            public string ISBN
            {
                get { return _ISBN; }
                set { _ISBN = value; }
            }
          
            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            
            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }

            public Book(string isbn, string title, int year)
            {
                _ISBN = isbn;
                _title = title;
                _year = year;
            }

        }

        Dictionary<string, Book> books = new Dictionary<string, Book>();

        public Form1()
        {
            var book1 = new Book("978-0547928227", "The Hobbit", 2012);
            var book2 = new Book("978-0547928210", "The Ring", 2012);
            var book3 = new Book("978-0547928197", "The King", 2012);

            books.Add(book1.ISBN, book1);
            books.Add(book2.ISBN, book2);
            books.Add(book3.ISBN, book3);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var book in books.Values)
            {
                var item = new ListViewItem(new string[] { book.ISBN, book.Title,
                    book.Year.ToString() });
                item.Name = book.ISBN;
                lstBooks.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var year = 0;
            var success = Int32.TryParse(txtYear.Text, out year);

            if (success && year > 0)
            {
                var newBook = new Book(txtISBN.Text, txtTitle.Text, year);
                books.Add(newBook.ISBN, newBook);

                var item = new ListViewItem(new string[] { newBook.ISBN, newBook.Title,
                    newBook.Year.ToString() });
                item.Name = newBook.ISBN;
                lstBooks.Items.Add(item);

                txtISBN.Text = String.Empty;
                txtTitle.Text = String.Empty;
                txtYear.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Not a valid year");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in lstBooks.SelectedItems)
            {
                books.Remove(item.ToString());
                lstBooks.Items.Remove((ListViewItem)item);
            }
        }
    }
}
