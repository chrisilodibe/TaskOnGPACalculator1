using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnGPACalculator
{
    public class InputCollector
    {
        //creating list to store collected data
       public List<string>CourseCode = new List<string>();
       public List<int>CourseUnit = new List<int>();  
       public List<int>Score = new List<int>();
       public List<string>Grade = new List<string>();
       public List<int> GradeUnit = new List<int>();
       public List<int> WeightPoint = new List<int>();
        public List<string>Performance =new List<string>();
       public string coursecode;
       public int NumOfSub;

        public void Input()
        {
            Console.WriteLine("WELCOME TO YOUR GPA CALCULATOR SYSTEM");
            Console.WriteLine("\n");

            Console.WriteLine("Enter the number of subjects:");
            string NumInput = Console.ReadLine();
            while(!int.TryParse(NumInput, out NumOfSub) || NumOfSub<=0)
            {
                Console.WriteLine("Entry should only be a whole number");
                Console.WriteLine("Enter the number of subjects:");
                NumInput = Console.ReadLine();
            }

            //to iterate through to pick the courses done by the student 
            for (int i = 0; i < NumOfSub; i++)
            {
                // for taking courseCode input from the user and validating the input upon collection to meet requirement
                Console.WriteLine("Enter Your CourseCode");
                coursecode = Console.ReadLine();
                while (int.TryParse(coursecode, out _) || coursecode == "" || coursecode.Length > 6 || coursecode.Length < 6) 
                {
                    Console.WriteLine("Please use the following format to enter your coursecode: MTH384, PHY233");
                    Console.WriteLine("Enter Your CourseCode");
                    coursecode = Console.ReadLine();
                }
                CourseCode.Add(coursecode);

                // for taking courseUnit input from the user and validating the input upon collection to meet requirement
                int Cunit;
                Console.WriteLine("Enter Your CouerseUnit");
                string cunit = Console.ReadLine();
                while(!int.TryParse(cunit, out  Cunit) || Cunit < 0 || Cunit > 5)
                {
                    Console.WriteLine("Entry should not be 0 or greater than 5");
                    Console.WriteLine("Enter Your CouerseUnit");
                    cunit = Console.ReadLine();
                }
                CourseUnit.Add(Cunit);

                // for taking Score input from the user and validating the input upon collection to meet requirement
                int score;
                Console.WriteLine("Enter Your score");
                string sInput = Console.ReadLine(); 
                while(!int.TryParse(sInput, out score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Your score should be a whole number not more than 100");
                    Console.WriteLine("Enter Your score");
                     sInput = Console.ReadLine();
                }
                Score.Add(score);
                Console.Clear();

                Grade.Add(Score[i] >= 70 ? "A" : Score[i] >= 60 ? "B" : Score[i] >= 50 ? "C" : Score[i] >= 45 ? "D" : Score[i] >= 40 ? "E" : "F");
                GradeUnit.Add(Score[i] >= 70 ? 5 : Score[i] >= 60 ? 4 : Score[i] >= 50 ? 3 : Score[i] >= 45 ? 2 : Score[i] >= 40 ? 1 : 0);
                Performance.Add(GradeUnit[i] == 5 ? "Excellent" : GradeUnit[i] == 4 ? "Very Good" : GradeUnit[i] == 3 ? "Good" : GradeUnit[i] == 2 ? "Pass" : GradeUnit[i] == 1 ? "Poor" : "Fail");
                WeightPoint.Add(CourseUnit[i] * GradeUnit[i]);
            }

            Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" | COURSECODE |   COURSEUNIT  |    SCORE   |     GRADE    |    GRADEUNIT   |    PERFORMANCE    |    WEIGHTPOINT  |  ");
            Console.WriteLine(" ----------------------------------------------------------------------------------------------------------------- ");
            Console.WriteLine(" |            |               |            |              |                |                   |                 |   ");

            for (int i = 0; i < NumOfSub; i++)
            {
                Console.WriteLine($" |   {CourseCode[i],-9}|       {CourseUnit[i],-6}  |     {Score[i]}     |       {Grade[i],-4}   |       {GradeUnit[i],-5}    |     {Performance[i]}     |        {WeightPoint[i],-8} |");
                Console.WriteLine("\n");
            }
            Console.WriteLine(" |            |               |            |              |                |                   |                 |");
            Console.WriteLine(" -----------------------------------------------------------------------------------------------------------------");

            //GPA Calculation
            int TotalWeightUnit= WeightPoint.Sum();
            int TotalCourseUnit = CourseUnit.Sum();
            int TotalGradeUnit = GradeUnit.Sum();
            double GPA = (TotalWeightUnit / TotalCourseUnit);
            string GPAin2Decimal = GPA.ToString("F2");

            // calling contructor printer
            Console.WriteLine("\n");
            printer Printer = new printer(TotalWeightUnit, TotalCourseUnit, TotalGradeUnit, GPAin2Decimal);

        }



    }
}
