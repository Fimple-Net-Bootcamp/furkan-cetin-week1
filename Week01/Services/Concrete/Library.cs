using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week01.Models;
using Week01.Services.Abstract;

namespace Week01.Services.Concrete
{
    public class Library : IPrintable
    {
        private ILoanable _loanStrategy;

        public Library(ILoanable loanStrategy)
        {
            _loanStrategy = loanStrategy;
        }

        public void LendBook(Book book, Member member)
        {
            _loanStrategy.LendItem(book, member);
        }

        public void ReturnBook(Book book, Member member)
        {
            _loanStrategy.ReturnItem(book, member);
        }

        public string WriteConsoleLendBook()
        {
            return "Kitap kiralanmıştır.";
        }

        public string WriteConsoleReturnBook()
        {
            return "Kitap iade edilmiştir.";
        }

    }
}


