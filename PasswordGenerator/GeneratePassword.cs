using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class GeneratePassword
    {
        public static string Generate(string letters)
        {
            Console.Write("Enter a password length: ");
            try
            {
                int passwordLength = Convert.ToInt32(Console.ReadLine()); // Convert user input to integer value
                Random rnd = new Random();
                char[] chars = new char[passwordLength]; // Create char array to the length of what the user inputted.
                for (int i = 0; i < passwordLength; i++)
                {
                    chars[i] = letters[rnd.Next(letters.Length)];
                }

                return new string(chars);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return e.ToString();
            }


        }
    }
}
