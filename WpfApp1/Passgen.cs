using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    class Passgen
    {
        private string word_lower = "abcdefghijklmnopqrstuvwxyz";
        private string word_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string numbers = "1234567890";
        private string symbol = "!()-.?[]_`~;:!@#$%^&*+=";
        private string strAvailableChar = "";
        public Passgen(bool WordLower, bool WordUpper, bool Numbers, bool Symbols)
        {
            if (WordLower)
                strAvailableChar = strAvailableChar + word_lower;
            if (WordUpper)
                strAvailableChar = strAvailableChar + word_upper;
            if (Numbers)
                strAvailableChar = strAvailableChar + numbers;
            if (Symbols)
                strAvailableChar = strAvailableChar + symbol;
        }
        public string Generate(int Lenght)
        {
            string pass = "";
            Random rnd = new Random();
            for (int i = 0; i < Lenght; i++)
            {
                pass = pass + strAvailableChar[rnd.Next(0, strAvailableChar.Length)];
            }
            return pass;
        }
    }
}
