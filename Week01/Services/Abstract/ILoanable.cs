using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week01.Models;

namespace Week01.Services.Abstract
{
    public interface ILoanable
    {
        void LendItem(Book book, Member member);
        void ReturnItem(Book book, Member member);
    }
}
