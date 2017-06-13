using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_delegation
{
    class Delete {
        public void show() {
            Console.WriteLine("show delete");
        }
    }
    class Program
    {
        private delegate void Del();

        private delegate string hi(string x);
        public static string hello(string x) {
            return "hello,"+x;
        }

        private delegate string csharp(int x);

        static void Main(string[] args)
        {
            Delete del = new Delete();
            Del method = new Del(del.show);
            method();
            hi hi1 = hello;
            Console.WriteLine(hi1("zhangsan"));
            csharp cs1 = delegate(int x) { return "string = " + x; };
            Console.WriteLine(cs1(10));
            csharp cs2 = (int x) => {return "cs2 = "+x;};
            csharp cs3 = x => { return "cs3 = " + x; };
            Console.WriteLine(cs3(123));
        }
        //csharp cs3 = x => { return "cs3 = " + x; };
        public static string cs3(int x) {
            return "cs3_ = " + x;
        }
    }
}
