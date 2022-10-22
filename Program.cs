using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("0");
            Console.WriteLine(myList.Length);
            myList.Add("1");
            Console.WriteLine(myList.Length);
            myList.Add("2");
            Console.WriteLine(myList.Length);
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
