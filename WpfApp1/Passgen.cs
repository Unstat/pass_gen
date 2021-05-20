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
        private bool _WordLower;
        private bool _WordUpper;
        private bool _Numbers;
        private bool _Symbols;
        private string strAvailableChar = "";
        public Passgen(bool WordLower, bool WordUpper, bool Numbers, bool Symbols)
        {
            _WordLower = WordLower;
            _WordUpper = WordUpper;
            _Numbers = Numbers;
            _Symbols = Symbols;
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
            int x = Convert.ToInt32(_WordLower) + Convert.ToInt32(_WordUpper) + Convert.ToInt32(_Numbers) + Convert.ToInt32(_Symbols);
            for (int i = 0; i < Lenght; i++)
            {
                pass = pass + strAvailableChar[rnd.Next(0, strAvailableChar.Length)];
            }
            return pass;
        }
    }
}
