using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnGPACalculator
{
    internal class printer
    {
        public int TotalWeightPoint;
        public int TotalCourseUnit; 
        public int TotalGradeUnit;
        public string GPAin2Decimal;
        public printer(int TotalWeightPoint, int TotalCourseUnit, int TotalGradeUnit, string GPAin2Decimal) 
        {
            this.TotalWeightPoint = TotalWeightPoint;
            this.TotalCourseUnit = TotalCourseUnit;
            this.TotalGradeUnit = TotalGradeUnit;
            this.GPAin2Decimal = GPAin2Decimal;

            Console.WriteLine($"Total Weight Point: {TotalWeightPoint}");
            Console.WriteLine($"Total Course Unit: {TotalCourseUnit}");
            Console.WriteLine($"Total Grade Unit: {TotalGradeUnit}");
            Console.WriteLine($"GPA: {GPAin2Decimal}");
        }
    }
}
