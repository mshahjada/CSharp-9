using CSharp9.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public static class SetInitEx
    {

        public static void HandsOn()
        {
            var obj = new Student()
            {
                Name = "Adil",
                Age = 21,
                Semester = "7 th"

            };

            Console.WriteLine($"{obj.Name}");
            Console.ReadKey();
        }

    }
}
