using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Services.Abstract
{
    public interface IPrintable
    {
        string WriteConsoleLendBook();
        string WriteConsoleReturnBook();
    }
}
