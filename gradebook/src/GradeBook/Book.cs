using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public void GetStatistics()
        {
            var average = 0.0;
            var low = Double.MinValue;
            var high = Double.MaxValue;

            foreach (var grade in grades)
            {
                low = Math.Min(grade, low);
                high = Math.Max(grade, high);
                average += grade;
            }
            average /= grades.Count;
            Console.WriteLine($"A media do aluno é de: {average}");
            Console.WriteLine($"A menor nota do aluno é de: {low}");
            Console.WriteLine($"A maior nota do aluno é de: {high}");
            
        }
        private List<double> grades = new List<double>();
        private string name;
    }
}