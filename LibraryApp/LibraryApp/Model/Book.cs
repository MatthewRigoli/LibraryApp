using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Model
{
    [Table("Book")]
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Unique]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }

    }
}
