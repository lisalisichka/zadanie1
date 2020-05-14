using System;

namespace lab1
{
    public class Lib1
    {
        public string stpow(string a, int b)
        {
            string resString = "";

            for (int i = 0; i < b; i++)
            {
                resString += a;
            }
            return resString;
        }

        public string rev(string a)
        {
            string resString = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                resString += a[i];
            }
            return resString;
        }

        public string remov(string str, string s)
        {
            return str.Replace(s, "");
        }

        public int leng(string str)
        {
            return str.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lib1 d = new Lib1();

            Console.WriteLine(d.stpow("Liz", 5));
            Console.WriteLine(d.rev("Lisa"));
            Console.WriteLine(d.remov("ccppt", "n"));
            Console.WriteLine(d.leng("ddddd"));
        }
    }
}
