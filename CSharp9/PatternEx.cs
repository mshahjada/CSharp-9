using CSharp9.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    // 1. Declaration & Type Pattern: Run time type check of an expression
    // 2. Constant Pattern: Result is equal to a constant
    // 3. Relational Pattern: To compare an expression result with a constant
    // 4. Conjunction and Pattern: Compare result is in a range
    // 5. Logical Pattern: Not, And, Or
    // 6. Property Pattern: Mathes Expression properties Or fields against nested patterns
    // 7. Positional Pattern: Deconstruction the expression
    // 8. Var Pattern: Temporarily assigned vaiable to hold resut for the next level of work.
    // 9. Discard pattern: Handle null & does't correspond given value.
    //10. Parenthesized
    public static class PatternEx
    {

        public static void HandsOn()
        {
            Student student = new Student() { Age = 15 };
            Teacher teacher = new Teacher();
            Student student1 = null;


            var s = student.CheckDeclarationType();
            s= student1.CheckDeclarationType();

            var res = student.StudentUnderAges();

            int[] arr = new int[] { 1, 2, 3, 4 };

            if(arr.SumCount() is var data && data.sum >= 10)
            {
                Console.WriteLine($"Result: {data.sum}; Items: {data.count}");
            }

            var isOdd = CheckOddNumber(8);

            Console.ReadKey();

        }

        //Declaration & Type Pattern

        //private static string CheckDeclarationType(this Person person) => person switch
        //{
        //    Student _ => "Student",
        //    Teacher _ => "Teacher",
        //    //null => "Null",
        //    _ => "Invalid"
        //};

        private static string CheckDeclarationType(this Person person) => person switch
        {
            Student => "Student",
            Teacher => "Teacher",
            null => "Null",
            _ => "Invalid"
        };

        //Property Pattern
        private static bool StudentUnderAges(this Student student) => student is { Age: < 14 }; 

        //Var pattern
        private static (int sum, int count) SumCount(this int[] arr)
        {
            int sum = 0, count = 0;
            foreach(int item in arr){
                sum += item;
                count++;
            }
            return (sum, count);
        }

        //Discard pattern

        private static bool CheckOddNumber(int number) => (number%2) switch
        {
            > 0 => true,
            _ => false
        };
    }
}
