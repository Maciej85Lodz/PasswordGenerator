using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    class CharGenerator
    {
        public static Random rnd = new Random();
        private const string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialCharacters;


        public static char GenerateCharFromCharacters(string availableChars)
        {

            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }

        public static char GenerateCapitalLetter()
        {
            Char randomChar = GenerateCharFromCharacters(CapitalLetters);
            return randomChar;
        }
        public static char GenerateSmalllLetter()
        {
            Char randomChar = GenerateCharFromCharacters(SmallLetters);
            return randomChar;
        }
        public static char GenerateDigits()
        {
            Char randomChar = GenerateCharFromCharacters(Digits);
            return randomChar;
        }
        public static char GenerateSpecial()
        {
            Char randomChar = GenerateCharFromCharacters(SpecialCharacters);
            return randomChar;
        }
        public static char GenerateAll()
        {
            Char randomChar = GenerateCharFromCharacters(AllChars);
            return randomChar;
        }
    }
}
