using System;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] numbers = new double[3] { 12.22, 43.99, 9.33 };
      double result = 0;
      foreach(double number in numbers) {
        result += number;
      }

      Console.WriteLine(result);
    }
  }
}
