using System;
public class DivideByZeroNoExceptionHandling
{
    static void Main()
    {
        // get numerator
        Console.Write( "Please enter an integer numerator: " );
        int numerator = Convert.ToInt32(Console.ReadLine());
        
        // get denominator
        Console.Write( "Please enter an integer denominator: " );
        int denominator = Convert.ToInt32( Console.ReadLine() );
        
        // divide the two integers, then display the result
        int result = numerator / denominator;
        Console.WriteLine( "\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result );

    } // end Main
}