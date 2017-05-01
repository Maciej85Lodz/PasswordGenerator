using RandomPasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    class RandomPasswordGenerator
    {
        public static Random random = new Random();
        public static char GenerateCharFromCharacters(string availableChars)
        {

            int randomIndex = random.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetter = CharGenerator.GenerateCapitalLetter();
                insertAtRandomPositions(password, capitalLetter);
            }
            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = CharGenerator.GenerateSmalllLetter();
                insertAtRandomPositions(password, smallLetter);
            }
            char digits = CharGenerator.GenerateDigits();
            insertAtRandomPositions(password, digits);

            for (int i = 1; i <= 3; i++)
            {
                char specialChar = CharGenerator.GenerateSpecial();
                insertAtRandomPositions(password, specialChar);
            }
            int count = CharGenerator.rnd.Next(8);
            for (int i = 1; i < count; i++)
            {
                char specialChar = CharGenerator.GenerateAll();
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
            int randomPossition = CharGenerator.rnd.Next(password.Length + 1);
            password.Insert(randomPossition, character);
        }
    }
}

