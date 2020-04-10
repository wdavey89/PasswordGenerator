using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PasswordGenerator.exe";
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!£$%^&*()_<>?";
            var password = GeneratePassword.Generate(letters);
            Console.WriteLine(password);
        }
    }
}
