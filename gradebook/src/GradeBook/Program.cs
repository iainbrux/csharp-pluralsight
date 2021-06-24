using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book("Iain's Grade Book");

      book.AddGrade(32.3);
      book.AddGrade(42.1);
      book.AddGrade(12.6);
      book.AddGrade(82.9);
      book.AddGrade(64.6);

      book.ShowStats();
    }
  }
}
