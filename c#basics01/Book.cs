using System;
using System.Collections.Generic;
using System.Text;

namespace c_basics01
{
    internal class Book
    {
        #region question1
        public int pages;
        public String title;

        public void print()
        {
            Object obj = new Book();
            Console.WriteLine(obj);
        }

        #endregion
    }
}
