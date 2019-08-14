using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IEnumerable and IEnumerator interfaces in .NET are implementations of the iterator pattern
namespace IEnumerable_and_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNonGenericList getDoubles = new MyNonGenericList(20);

            // we can use foreach only to step through an enumerable collection
            // As our MyList class implements IEnemerable interface, we can use it in foreach loop
            foreach (var i in getDoubles)
            {
                Console.WriteLine(i);
            }

            // When you compile your code, the compiler translates your foreach block to a 
            // while loop like the earlier example. So, under the hood, it’ll use the 
            // IEnumerator object returned from GetEnumerator method
            Console.WriteLine("---------Now using GetEnumerator() method---------");
            var iter = getDoubles.GetEnumerator();
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
            // So, while you can use the foreach block on any types that implements IEnumerable,
            // IEnumerable is not designed for the foreach block!

            Console.Read();
        }
    }
}
