using System;

namespace Opdracht4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-- Opdracht 4: Rekenmachine --");

            int number1 = 8;
            int number2 = 3;

            static int Sum(int number1, int number2){
                Console.WriteLine("- SOM -");
                return number1 + number2;
            }

            static int Subtract(int number1, int number2){
                Console.WriteLine("- VERSCHIL -");
                return number1 - number2;
            }

            static int Multiply(int number1, int number2){
                Console.WriteLine("- VERMENIGVULDIGEN -");
                return number1 * number2;
            }

            static double Divide(int number1, int number2){
                Console.WriteLine("- DELEN -");
                return (double)number1 / number2;
            }

            string Faculteit(int FacNumber) {
                Console.WriteLine("- FACULTEIT -");
                uint Counter = 1;
                // datatype ulong (voor result) zodat het resultaat bij een groter getal ook correct is
                ulong Faculteit= 1;
                while (Counter <= FacNumber)
                {   
                    Faculteit = Faculteit * Counter;
                    Counter++;
                }
                return "De faculteit van "+ FacNumber + " is " + Faculteit + ".";
            }

            string Fibonacci(int Length) {
                Console.WriteLine("- FIBONACCI -");
                ulong Fibo1 = 1;
                ulong Fibo2 = 0;
                string result = "De fibonacci reeks van " + Length + " getallen is: " + Fibo2 + " " + Fibo1;            
                for (int i = 0; i < Length-2; i++)
                {
                    ulong Fibo3 = Fibo2;
                    Fibo2 = Fibo1;
                    Fibo1 = Fibo3 + Fibo1;
                    result = result + " " + Fibo1;
                }
                return result;
            }

            Console.WriteLine(Sum(number1, number2));
            Console.WriteLine(Subtract(number1, number2));
            Console.WriteLine(Multiply(number1, number2));
            Console.WriteLine(Divide(number1, number2));

            Console.WriteLine(Faculteit(5));
            Console.WriteLine(Fibonacci(10));
        }
    }
};