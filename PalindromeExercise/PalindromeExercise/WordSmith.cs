using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            var toLower = input.ToLower(); 

            char[] inputChars = toLower.ToCharArray();
            Array.Reverse(inputChars);

            string checkPalindrome = new String(inputChars);

            if (checkPalindrome == toLower)
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
