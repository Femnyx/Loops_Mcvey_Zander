using System;

namespace Loops_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user "Why do you want to make games?" and will record it with the command under line 10
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();

            //The Console prints how many spaces are used in the user's response.
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            //The Console asks the user to enter a whole number and will store the response under string response2.
            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();

            //Tells the user the sum of the individual digits they responded with.
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of Spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                numberOfSpaces++;
                
            }

            return numberOfSpaces;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            return sum;
        }

    }
}
