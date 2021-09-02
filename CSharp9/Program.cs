using CSharp9.Model;
using System;
using System.Threading.Tasks;

namespace CSharp9
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Record 
            //RecordEx.HandsOn();

            //2. Set/Init
            //SetInitEx.HandsOn();

            //3. Pattern 

            PatternEx.HandsOn();

        }

        private Student GetStudent()
        {
            return new();
        }
    }

}
