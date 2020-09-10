using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj
{
    class Program
    {
        int iNum1 = 0, iNum2 = 0;
        void GetNumbers()
        {
            while(!Int32.TryParse(Console.ReadLine(),out iNum1) || iNum1<=0)
            {
                Console.WriteLine("Invalid entry for Num1,Please try again");
            }
            while (!Int32.TryParse(Console.ReadLine(), out iNum2) || iNum2 <= 0)
            {
                Console.WriteLine("Invalid entry for Num2,Please try again");
            }
            Add();
        }
        private void Add()
        {
            int add = iNum1 + iNum2;
            Console.WriteLine("Sum is"+add);
        }
        static void Main(string[] args)
        {
            new Program().GetNumbers();
            Console.Read();
        }
    }
}
