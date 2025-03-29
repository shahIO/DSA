using _2_BitMagic;

// Operators
Console.WriteLine(_1_Operators.AndOperator(5, 3));
Console.WriteLine(_1_Operators.OrOperator(6, 7));
Console.WriteLine(_1_Operators.XorOperator(6, 7));
Console.WriteLine(_1_Operators.NotOperator(13));
Console.WriteLine(_1_Operators.LeftShiftOperator(13));
Console.WriteLine(_1_Operators.RightShiftOperator(13));


// Check if Kth bit is set or not
Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Naive(18, 1));
Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Naive(18, 2));
Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Naive(18, 3));
Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Naive(18, 4));
Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Naive(18, 5));

Console.WriteLine(_2_KthBitIsSetOrNot.IsKthBitIsSet_Optimize(18, 4));


//Count set bit
Console.WriteLine(_3_CountSetBit.CountSetBit_Naive(180));
Console.WriteLine(_3_CountSetBit.CountSetBit_Optimize(180));


Console.WriteLine(_4_PowerOfTwo.Check_Naive(1));
Console.WriteLine(_4_PowerOfTwo.Check_Optimize(1));



int[][] testCases =
[
    [1, 2, 3, 2, 3, 1, 3],
    [4, 5, 4, 5, 4],
    [10, 20, 20, 10, 10],
    [7, 7, 8, 8, 8],
    [15, 15, 15, 15, 15],
];

int[][] evenOccuranceTestCases =
[
    [3, 3, 3, 3],
    [4, 5, 4, 5, 4, 5],
    [10, 20, 20, 10, 20, 10],
    [7, 7, 8, 8, 9, 9],
    [15, 15, 15, 15, 15, 15],
];


for (int i = 0; i < testCases.Length; i++)
{
    int result = _5_FindOddOccuring.FindOddOccurring_Naive(testCases[i]);
    Console.WriteLine(result);

    int optResult = _5_FindOddOccuring.FindOddOccurring_Optimized(testCases[i]);
    Console.WriteLine(optResult);
}

for (int i = 0; i < evenOccuranceTestCases.Length; i++)
{
    int result = _5_FindOddOccuring.FindOddOccurring_Naive(evenOccuranceTestCases[i]);
    Console.WriteLine(result);

    int optResult = _5_FindOddOccuring.FindOddOccurring_Optimized(evenOccuranceTestCases[i]);
    Console.WriteLine(optResult);
}