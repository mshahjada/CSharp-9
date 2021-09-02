using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public static class RecordEx
    {
        public static void HandsOn()
        {
            string[] roles = new string[2];
            employee employee1 = new("Md", "Sagor", roles);
            employee employee2 = new("Md", "Sagor", roles);

            StudentInfo student3 = new StudentInfo { fname = "Md", lname = "Sagor", roles = new string[1] };


            employee2 = employee1 with { lname = "Shahjada" };


            Console.WriteLine(employee1);
            employee2 = employee1 with { };
            Console.WriteLine(employee2 with { } == employee1);
        }

    }

    public abstract record person(string fname, string lname);
    public record employee(string fname, string lname, string[] roles) : person(fname, lname);


    public record Per
    {
        public string fname { get; set; }
        public string lname { get; set; }
    }
    public record StudentInfo : Per
    {
        public string[] roles { get; set; }
    }

}
