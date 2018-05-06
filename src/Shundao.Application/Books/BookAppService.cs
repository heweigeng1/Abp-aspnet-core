using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Books
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IRepository<Book,long> _bookRepository;
        public BookAppService(IRepository<Book, long> bookRepositor)
        {
            _bookRepository = bookRepositor;
        }
        public void Test()
        {
            _bookRepository.Insert(new Book());
        }
    }
}
