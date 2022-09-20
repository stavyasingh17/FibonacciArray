using System;

class FibonacciArray
{
    
    static void Main ()
    {
        //Create an array of ints
        int[] fib = new int[25];
        //Set the first two locations to 1
        fib[0] = 1;
        fib[1] = 1;
        //Set each subsequent location in a loop
        for (int i = 2; i < fib.Length; i++)
            fib[i] = fib[i - 1] + fib[i - 2];

        //Display the elements after computed
        Console.WriteLine("The first" + fib.Length + "Fibonacci numbers are:");
        for (int i = 0; i < fib.Length; i++) Console.WriteLine("" + fib[i]);

    }
}