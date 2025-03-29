
namespace _3_Recursion
{
    class _1_Intro
    {
        //Execution of methods
        public static void Fun1()
        {
            Console.WriteLine("Fun");
        }

        public static void Fun2()
        {
            Console.WriteLine("Before Fun1!");
            Fun1();
            Console.WriteLine("After Fun1!");
        }

        //Infinite recursion
        public static void Foo()
        {
            // Since no base case hence infinite loop
            Console.WriteLine("Hello Shah");
            Foo();
        }

        //Finite recursion
        public static void Bar(int n)
        {
            //Base case
            if (n == 0)
            {
                return;
            }

            Console.WriteLine("Shah");
            Bar(n - 1);
        }

        // Practise
        public static void Func1(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            Func1(n - 1);
            Console.WriteLine(n);
        }

        public static void Func2(int n)
        {
            if (n == 0)
            {
                return;
            }
            Func2(n - 1);
            Console.WriteLine(n);
            Func2(n - 1);
        }
    }
}
