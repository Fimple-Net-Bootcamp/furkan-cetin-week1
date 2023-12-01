using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Week01.Models;
using Week01.Services.Abstract;

namespace Week01.Services.Concrete
{
    public class ShortTermLoan : ILoanable
    {
        public void LendItem(Book book, Member member)
        {
            member.Books.Add(book);
            Console.WriteLine("Kitap Kısa dönem kiralanmıştır.");
        }

        public void ReturnItem(Book book, Member member)
        {
            member.Books.Remove(book);
            Console.WriteLine("Kitap iade edilmiştir.");
        }

    }
}
