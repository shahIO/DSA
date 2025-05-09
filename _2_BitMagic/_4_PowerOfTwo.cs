﻿//Naive
// Doubling n each time, and checks if it equals the input.
// If n matches the input during the iteration, it returns true.
// If the loop completes without finding a match, it returns false.
// Time Complexity: 𝑂(logn)

//Optimize
//We can use the property that a power of 2 has only one bit set in its binary representation.
//The expression (n & (n - 1)) == 0 can be used to check if a number is a power of 2.
// Time Complexity: O(1)


namespace _2_BitMagic
{
    class _4_PowerOfTwo
    {
        public static bool Check_Naive(int input)
        {
            int n = 1;
            while (n <= input)
            {
                if (n == input)
                {
                    return true;
                }
                n = n * 2;
            }
            return false;
        }

        public static bool Check_Optimize(int input)
        {
            // A power of 2 must be greater than 0 and must have only one bit set
            return input > 0 && (input & (input - 1)) == 0;
        }
    }
}
