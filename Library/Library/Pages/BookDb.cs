﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Books
{
    internal class BookDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
