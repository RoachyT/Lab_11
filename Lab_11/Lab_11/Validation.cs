using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_11
{
    class Validation
    {

        private int _numbers;
        private string _letters;
        
       

        public Validation(string letters, int numbers)
        {
            _numbers = numbers;
            _letters = letters;
        }

        public static bool areNumbersValid(int numbers)
        {
            
            if (Regex.IsMatch(numbers.ToString(),@"[0-9]"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool areLettersValid(string letters)
        {//Regex checkingletter = new Regex(@"[A - z]");
            if (Regex.IsMatch(letters, @"[A-z]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
