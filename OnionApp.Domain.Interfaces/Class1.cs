namespace OnionApp.Domain.Interfaces
{
    using System.Collections.Generic;
    using System;
    using OnionApp.Domain.Core;

    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBookList();

        Book GetBook(int id);

        void Create(Book item);

        void Update(Book item);

        void Delete(int id);

        void Save();
    }
}
