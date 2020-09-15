using System;
namespace CSharp_Testing
{
    public class NumbersStartAndEndWithDigit3
    {
        public NumbersStartAndEndWithDigit3()
        {
        }

        public static void Run()
        {
            int count = 3;
            int n = 1000;

            while(count < 100)
            {
                if (n % 10 == 3)
                {
                    int _n = n;
                    int remain = 0;

                    while (n > 0)
                    {
                        remain = _n % 10;
                        _n = _n / 10;
                    }

                    if (remain == 3)
                    {
                        count++;
                        Console.WriteLine($"{count}) {n}");
                    }
                }
                n++;
            }

        }
    }
}
