using Problems;

namespace Problems
{
    public class Fibonacci
    {

        // basic recursive 
        public int GetFibonacciNumber(int number)
        {
            if (number <= 0)
                return 0;
            else if (number <= 2)
                return 1;
            else
                return GetFibonacciNumber(number - 1) + GetFibonacciNumber(number - 2);

        }

        public int GetFibonacciNumber_DP_Bottom_UP(int number)
        {
            if (number <= 0)
                return 0;
            else if (number <= 2)
                return 1;
            else
            {
                int[] memoized = new int[number + 1];
                memoized[0] = 0;
                memoized[1] = 1;
                for (int i = 2; i <= number; i++)
                {
                    memoized[i] = memoized[i - 1] + memoized[i - 2];
                }

                return memoized[number];
            }

        }

        public int GetFibonacciNumber_DP_Top_Down(int number)
        {
            if (number <= 0)
                return 0;
            else if (number <= 2)
                return 1;
            else
            {
                int[] memoized = new int[number + 1];
                memoized[0] = 0;
                memoized[1] = 1;
                
                return GetFibonacciNumber_Memoized(number, memoized);
            }

        }

        private int GetFibonacciNumber_Memoized(int number, int[] memoized)
        {
            if (number <= 1)
                return number;

            if (memoized[number] != 0)
                return memoized[number];
            else
                memoized[number] = GetFibonacciNumber_Memoized(number -1, memoized) + GetFibonacciNumber_Memoized(number - 2, memoized);
                
            return memoized[number];
        }


    }
}
