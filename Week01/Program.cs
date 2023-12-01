using Week01.Models;
using Week01.Services.Abstract;
using Week01.Services.Concrete;

class Program
{
    static void Main(string[] args)
    {
        ILoanable loanStrategy = new ShortTermLoan();

        Library library = new Library(loanStrategy);

        var book = new Book { Id = 1, Name = "Harry Potter", Author = "Rowling" };
        var member = new Member { Id = 1, Name = "Furkan", Surname = "Çetin" };

        library.LendBook(book, member);
        library.WriteConsoleLendBook();

        library.ReturnBook(book, member);
        library.WriteConsoleReturnBook();

        Console.ReadKey();

    }
}