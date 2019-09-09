using System;
using System.Collections.Generic;
using System.Text;

namespace PLO
{
    public static class RandomGenerator
    {
        public static List<int> Draw(int numberOfElements)
        {
            Random rand = new Random();
            List<int> result = new List<int>();
            int[] forDraw = new int[numberOfElements];

            for(int i = 0; i < numberOfElements; i++)
            {
                forDraw[i] = i;
            }

            int n = numberOfElements;

            for(int i = 0; i < numberOfElements; i++)
            {
                int r = rand.Next(n);
                result.Add(forDraw[r]);
                forDraw[r] = forDraw[n - 1];
                n--;
            }
            return result;
        }
    }
}
