using LibraryApp.Database;
using LibraryApp.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Diabetes.Database
{
    public class SqliteDataService //: ILocalDataService
    {
        private SQLiteConnection _database;

        public SqliteDataService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryAppDB.db3");
            Console.WriteLine(dbPath);
            try
            {
                _database = new SQLiteConnection(dbPath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);
            }
            catch (Exception ex)
            {

            }

            _database.CreateTable<Book>();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void AddItem(Book book)
        {
            if (book is null)
            {
                return;
            }

            AddBook(book);
        }

        public void UpdateItem(Book book)
        {
            if (book is null)
            {
                return;
            }

            UpdateBook(book);
        }

        /* ------- RECIPE STUFF ------- */

        public void AddBook(Book book)
        {
            _database.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            _database.Update(book);
        }

        public void DeleteBook(Book book)
        {
            _database.Delete(book);
        }

        public IEnumerable<Book> GetBook()
        {
            return _database.GetAllWithChildren<Book>();
        }
    }
}