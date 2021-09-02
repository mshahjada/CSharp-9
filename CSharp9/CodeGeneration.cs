using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    /*
        C#9 code generation has two features
        
        Normally code generators read attributes & other code elements by Roslyn Analysis API
        
        1. Partial method syntax

          In C#9, remove restriction of partial method declaration with access modifier.
          introduce return type & out parameter



        2. Module initializer
    */
    public static class CodeGeneration
    {
       public static void HandsOn()
       {
            int res;
            Area.Calculate(2, 3,out res);
            Console.WriteLine($"Area is: {res}");
        }
    }


    static partial class Area
    {
        public static partial void Calculate(int h, int w, out int res);
    }

    static partial class Area
    {
        public static partial void Calculate(int h, int w, out int res) => res = h * w;

    }


}
