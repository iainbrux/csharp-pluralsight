using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] numbers = new double[3] { 12.22, 43.99, 9.33 };
      List<double> grades  = new List<double>() { 12.22, 43.99, 9.33 };

      grades.Add(16.1);
      grades.Add(77.3);

      double result = 0;

      foreach(double number in grades) 
      {
        result += number;
      }
      result /= grades.Count;
      System.Console.WriteLine($"The average grade is {result:N2}");
    }
  }
}
