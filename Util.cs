using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

           do
            {
                Console.WriteLine(prompt);
				answer = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("You must enter something!");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static int AskForInt(string prompt)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt);
                success = int.TryParse(input, out answer);
                
                if(!success)
					Console.WriteLine("Only numbers!");

            } while (!success);

            return answer;
        }
    }
}
