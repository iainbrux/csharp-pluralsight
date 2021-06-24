using System.Collections.Generic;
using System;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade) 
    {
      grades.Add(grade);
    }

    public void ShowStats()
    {
      double result = 0;
      double highestGrade = double.MinValue;
      double lowestGrade = double.MaxValue;
      
      foreach (double number in grades)
      {
        result += number;
        highestGrade = Math.Max(number, highestGrade);
        lowestGrade = Math.Min(number, lowestGrade);
      }

      double averageGrade = (result /= grades.Count);

      System.Console.WriteLine($"The highest grade is {highestGrade}");
      System.Console.WriteLine($"The lowest grade is {lowestGrade}");
      System.Console.WriteLine($"The average grade is {averageGrade}");
    }

    private List<double> grades;
    private string name;
  }
}