using System;

namespace ExampleProject {
    class Program {
        static void Main(string[] args) {
            
            // Declaring Variables
            // Variables have data types    
            int num1;
            string name;
            // assigning variables 
            name = "Burrito Bison";
            name = "Chill Bill";

            num1 = 90;

            // Read Input off keyboard
            Console.WriteLine("Please enter a number: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Please enter another number:");
            string input2 = Console.ReadLine();

            // Convert strings to ints
            num1 = int.Parse(input1);
            //create a variable called num2 and store a int version of input in it
            int num2 = int.Parse(input2); 

            // Print out the result of num1 * num2
            int total = num1 * num2;
            Console.WriteLine("Total is" +" " + total);
            Console.WriteLine("num1 x num2 =" + " " + num1 *num2);

            //Selection if - else
            //if (condition)  -condition's outcome must be binary (true or false)
            // else - no condition, is the opposite path/evaluation of the ifs condition

            //total is greater than 1000 - print total is greater than 1000, otherwise print total is less than 1000
            if ( total >= 1000 ) {
                //if true
                
                //nested ifs
                if (total == 1000) {
                    Console.WriteLine("total is greater than 1000");
                } else {
                    Console.WriteLine("total is less than 1000");            
                }
        }   else {
            Console.WriteLine("total is less than 1000");
        }
            //Another way to do it. Same result, different path to get there. Which way is better?
            //total = 2000
            if (total <= 1000)
            {
            }
            else
            {
                Console.WriteLine("total is greater than 1000");
            }
            if ( total == 1000 ) {
                Console.WriteLine("total is equal to 1000");
            }
            if ( total < 1000 ) {
                Console.WriteLine("total is less than 1000");
            }
        }

        }
    }

