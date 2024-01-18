using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    internal class EnumList
    {
        public void Display()
        {
            Console.WriteLine("Enter a numbers");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine($"{Days.Monday}");
                    break;
                case 2:
                    Console.WriteLine($"{Days.Tuesday}");
                    break;
                case 3:
                    Console.WriteLine($"{Days.Wednesday}");
                    break;
                case 4:
                    Console.WriteLine($"{Days.Thursday}");
                    break;
                case 5:
                    Console.WriteLine($"{Days.Friday}");
                    break;
                case 6:
                    Console.WriteLine($"{Days.Saturday}");
                    break;
                case 7:
                    Console.WriteLine($"{Days.Sunday}");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
