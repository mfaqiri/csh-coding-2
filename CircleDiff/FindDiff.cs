using System;

namespace CircleDiff
{
    public class FindDiff
    {
        public static int diff(int radius){

            int result = 0;

            double square1 = Math.Sqrt(radius*radius*2);

            double square2 = radius*2;

            result = (int)Math.Round(square2*square2 - square1*square1);

            return result;

        }

    }
}
