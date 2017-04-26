using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    class RandomPasswordGenerator
    {

        private const string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialCharacters;
        private static Random rnd = new Random();
             
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 1; i < +2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                insertAtRandomPositions(password, capitalLetter);
            }
            for (int i = 1; i < +2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                insertAtRandomPositions(password, smallLetter);
            }
            char digits = GenerateChar(Digits);
            insertAtRandomPositions(password, digits);

            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialCharacters);
                insertAtRandomPositions(password, specialChar);
            }
            int count = rnd.Next(8);
            for (int i = 1; i < count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                insertAtRandomPositions(password, specialChar);
            }
            Console.WriteLine("Your password is:");
            Console.WriteLine(password);
            Console.WriteLine("Your passoword consists of {0} elements", password.Length);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void insertAtRandomPositions(StringBuilder password, char character)
        {
            //throw new NotImplementedException();
            int randomPossition = rnd.Next(password.Length + 1);
            password.Insert(randomPossition, character);
        }

        private static char GenerateChar(string availableChars)
        {

            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar =  availableChars[randomIndex];
            return randomChar;
        }
    }

}
