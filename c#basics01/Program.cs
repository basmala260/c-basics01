using System;

namespace c_basics01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question2
            //Object obj = new Book();
            //Console.WriteLine("=====================");
            //Console.WriteLine("object print:" + obj);
            //Console.WriteLine("======================");
            //Console.WriteLine("to string:" + obj.ToString());
            //Console.WriteLine("=======================");
            //Console.WriteLine("equals:" + obj.Equals(obj));
            //Console.WriteLine("=======================");
            //Console.WriteLine("hashcode:" + obj.GetHashCode());
            //Console.WriteLine("======================");
            //Console.WriteLine("gettype:" + obj.GetType());
            //Console.WriteLine("==========================");
            #endregion

            #region question3
            ////complie error
            //int pages = 464;

            #endregion

            #region question4

            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;

            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("catch block");
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine("======================");

            }
            finally
            {
                Console.WriteLine("finally block");
                Console.WriteLine("done");
            }
            #endregion

        }
    }
}
