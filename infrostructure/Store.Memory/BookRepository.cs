﻿using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository

    {
        private readonly Book[] books = new[]

        {

            new Book(1,"Art of programming"),

            new Book(2,"Refactoring"),

            new Book(3, "C Programming Language"),

        };

        public Book[] GetAllByTite(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}
