using System;

namespace c_basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question2
            Object obj = new Book();
            Console.WriteLine("=====================");
            Console.WriteLine("object print:" + obj);
            Console.WriteLine("======================");
            Console.WriteLine("to string:" + obj.ToString());
            Console.WriteLine("=======================");
            Console.WriteLine("equals:" + obj.Equals(obj));
            Console.WriteLine("=======================");
            Console.WriteLine("hashcode:" + obj.GetHashCode());
            Console.WriteLine("======================");
            Console.WriteLine("gettype:" + obj.GetType());
            Console.WriteLine("==========================");


            #endregion

        }
    }
}
