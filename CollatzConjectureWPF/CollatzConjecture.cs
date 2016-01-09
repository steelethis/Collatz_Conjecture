using System.Collections.Generic;

namespace CollatzConjectureWPF
{
    public class CollatzConjecture
    {
        private int num;

        public CollatzConjecture(int number)
        {
            num = number;
        }

        public Dictionary<int, int> Calculate()
        {
            int steps = 0;
            int n = num;

            Dictionary<int, int> calculations = new Dictionary<int, int>();

            while (n != 1)
            {
                calculations.Add(steps, n);
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                steps++;
            }

            return calculations;
        }
    }
}