using System;

namespace Delegate_Example
{
    class Program
    {
        public delegate int MyDelegate(int x);
        // Above delegate is compatible with any method with return type int and single int parameter

        static void Main(string[] args)
        {
            #region DELEGATES
            // A delegate is an object that knows how to call a method
            // A delegate type defines the kind of method that delegate instances can call
            // Specifically, it defines the method’s return type and its parameter types

            // Now we create a delegate instance by assign method to delegate
            // ComputeSquare take one int variable as parameter and return int
            // So it signature match to our delegate, we can assign it
            MyDelegate FunctionSquare = ComputeSquare;

            // We can call it like anyother normal method
            Console.WriteLine("Square of 5 = " + FunctionSquare(5));

            // We can also assign function to delegate using Lambda Expression
            MyDelegate LambdaDelegate = ((int x) => x * x);

            // Call LambdaDelegate
            Console.WriteLine("Square of 8 = " + LambdaDelegate(8));

            // A delegate instance literally acts as a delegate for the caller: the caller invokes the
            // delegate, and then the delegate calls the target method. This indirection decouples
            // the caller from the target method

            // TODO Yet to Test it
            // Technically, we are specifying a method group when we refer
            // to Square without brackets or arguments. If the method is
            // overloaded, C# will pick the correct overload based on the sig‐
            // nature of the delegate to which it’s being assigned

            // We can pass delegate as function/method argument
            // A method is assigned to a delegate at runtime, it is useful for writing plug-in methods

            // To double numbers array
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Pass ComputerSquare and nums array
            ApplyDelegate(ComputeSquare, nums);

            Console.WriteLine("Squares of first ten numbers");
            // Printing values
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            int[] newNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Cubes of first ten numbers");
            // Printing values
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            ApplyDelegate(ComputeCube, newNums);

            #endregion
            Console.ReadKey();
        }


        // Function to compute square
        public static int ComputeSquare(int number)
        {
            return number * number;
        }

        // Function to compute cubes
        public static int ComputeCube(int number)
        {
            return number * number;
        }

        // function to apply delegates to int[]
        public static void ApplyDelegate(MyDelegate myDelegate, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = myDelegate(numbers[i]);
            }

        }
    }
}

