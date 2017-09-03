using System;

namespace _9998539problem01.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction
            Console.WriteLine("This programs is designed to compare the values of two numbers and display which one is of a greater value.");
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please enter your first number.");
            //storing number 1 to variable
            var number1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            //storing number 2 to variable
            var number2 = Console.ReadLine();
            //converting number 1 to integer
            var numberone = 0;
            var isnumber1 = int.TryParse(number1, out numberone);
            //to give error message if number onecould not convert
            if(isnumber1) {
                var numbertwo = 0;
                var isnumber2 = int.TryParse(number2, out numbertwo);
                //to give error message if number could not convert
                if(isnumber2){
                    if(numberone > numbertwo) {
                    //To work out if number1 is less than, equal to or grater than number2
                    Console.WriteLine("Number 1 is greater than Number 2");
                    }
                    else {
                        if(numberone < numbertwo) {
                            Console.WriteLine("Number 1 is less than Number 2");
                       }
                        else {
                            Console.WriteLine("Number 1 is equal to Number 2");
                        }
                    }
                }
                else { 
                    Console.WriteLine("One of the values you entered was not a number.");
                }
            }
            else {
                Console.WriteLine("One of the values you entered was not a number.");
            }

            //To close program and clear console for next use.
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
