using _1_Mathematics;

//Count Digit
Console.WriteLine(_1_CountDigits.CountDigits(256));
Console.WriteLine(_1_CountDigits.CountDigitsUsingString(25632));


//Palindrome
Console.WriteLine(_2_Palindrome.IsPalindrome(121));
Console.WriteLine(_2_Palindrome.IsPalindrome("78987"));
Console.WriteLine(_2_Palindrome.IsPalindrome(-121));
Console.WriteLine(_2_Palindrome.IsPalindrome("21"));
Console.WriteLine(_2_Palindrome.IsPalindrome(10));
Console.WriteLine(_2_Palindrome.IsPalindrome("8"));
Console.WriteLine(_2_Palindrome.IsPalindrome(837));
Console.WriteLine(_2_Palindrome.IsPalindrome("837"));
Console.WriteLine(_2_Palindrome.IsPalindrome(8668));
Console.WriteLine(_2_Palindrome.IsPalindrome("A man, a plan, a canal: Panama"));
Console.WriteLine(_2_Palindrome.IsPalindrome("race a car"));
Console.WriteLine(_2_Palindrome.IsPalindrome(" "));


//Factorial
Console.WriteLine(_3_Factorial.Calculate(1));
Console.WriteLine(_3_Factorial.Calculate(5));
Console.WriteLine(_3_Factorial.Calculate(0));
Console.WriteLine(_3_Factorial.Calculate(100));


//Count trailing zeroes
Console.WriteLine(_4_CountTrailingZeroes.Calculate_Naive(5));
Console.WriteLine(_4_CountTrailingZeroes.Calculate_Naive(115));
Console.WriteLine(_4_CountTrailingZeroes.Calculate_Optimum(115));


//HCF
Console.WriteLine(_5_HCF.Calculate_Naive(100, 200));
Console.WriteLine(_5_HCF.Calculate_EuclideanAlgo(12, 98));
Console.WriteLine(_5_HCF.Calculate_EuclideanAlgoOptimized(24, 98));


//LCM
Console.WriteLine(_6_LCM.Calculate_Naive(15, 20));
Console.WriteLine(_6_LCM.Calculate_Optimized(15, 20));


//Check prime
for (int i = 0; i <= 100; i++)
{
    if (_7_CheckPrime.Check_Naive(i))
    {
        Console.WriteLine($"{i}");
    }
}

for (int i = 0; i <= 100; i++)
{
    if (_7_CheckPrime.Check_Optimized(i))
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine(_7_CheckPrime.Check_MoreOptimized(4));


//Prime factors
_8_PrimeFactor.Calculate(84);
_8_PrimeFactor.Calculate_Optimize(84);


//All divisors
_9_AllDivisors.Calculate_Naive(100);
_9_AllDivisors.Calculate_Optimize_NotSorted(100);
_9_AllDivisors.Calculate_Optimize_Sorted(100);
_9_AllDivisors.Calculate_Optimize_Sorted(84);
_9_AllDivisors.Calculate_Optimize_Sorted(1);
_9_AllDivisors.Calculate_Optimize_Sorted(2);


//Sieve of Eratosthenes
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(499979));
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(0));
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(1));
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(2));
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(3));
Console.WriteLine(_10_SieveOfEratosthenes.AllPrimes(4));