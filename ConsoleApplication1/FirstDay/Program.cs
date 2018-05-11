using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kissdanieldezso@gmail.com
            //kissdani.oktato.net/evo180510
            Coder c = new Coder("Steve");
            //Console.WriteLine(c.Name, Coder.Language.Csharp);
            bool isOk = c.Work(10);
            isOk = c.Work(10, true);

            //dynamic type -> this is way overload doesnt work with variable return types
            var percentage = c.Work(10);

            Coder Johnny = new Coder("Johnny", "python");
            Coder Johhyn2nd = new Coder("Joe", Coder.Language.Cpp);
            Console.WriteLine(Johnny.FavouriteLanguage.ToString());
            Console.WriteLine(Johhyn2nd.FavouriteLanguage);
            //Console.WriteLine(new Coder("name", "Python").FavouriteLanguage.ToString());

            
        }
    }
}
