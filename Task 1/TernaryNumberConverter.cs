using System;
using System.Text;

namespace Task_1
{
    class TernaryNumberConverter
    {
        public static String ToTernary(int number)
        {
            StringBuilder ternaryNumber = new StringBuilder();
            if (number == 0)
                return "";
            
            while (number>0)
            {
                ternaryNumber.Insert(0, number % 3);
                number /= 3;
            }

            return ternaryNumber.ToString();

        }
    }
}
