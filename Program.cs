using System;

namespace FundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++) {
                Console.WriteLine("1. -> " + i);
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    if (i % 5 != 0) {
                        Console.WriteLine("2.1. -> " + i);
                    }
                }
                if (i % 5 == 0) {
                    if ( i % 3 != 0) {
                        Console.WriteLine("2.2. -> " + i);
                    }
                }
            }
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    if (i % 5 != 0) {
                        Console.WriteLine("Fizz");
                    }
                }
                if (i % 5 == 0) {
                    if ( i % 3 != 0) {
                        Console.WriteLine("Buzz");
                    }
                }
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
            }
            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            //! Uncomment below and comment above to run the while loops.

            // int i = 1;
            // while (i <= 255) {
            //     Console.WriteLine("1. -> " + i);
            //     i++;
            // }
            // i = 1;
            // while (i <= 100) {
            //     if (i % 3 == 0) {
            //         if (i % 5 != 0) {
            //             Console.WriteLine("2.1. -> " + i);
            //         }
            //     }
            //     if (i % 5 == 0) {
            //         if ( i % 3 != 0) {
            //             Console.WriteLine("2.2. -> " + i);
            //         }
            //     }
            //     i++;
            // }
            // i = 1;
            // while (i <= 100) {
            //     if (i % 3 == 0) {
            //         if (i % 5 != 0) {
            //             Console.WriteLine("Fizz");
            //         }
            //     }
            //     if (i % 5 == 0) {
            //         if ( i % 3 != 0) {
            //             Console.WriteLine("Buzz");
            //         }
            //     }
            //     if (i % 3 == 0 && i % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     i++;
            // }
            // i = 1;
        }
    }
}
