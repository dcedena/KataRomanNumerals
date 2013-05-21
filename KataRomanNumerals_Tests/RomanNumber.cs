using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KataRomanNumerals_Tests
{
    public class RomanNumber
    {
        private Dictionary<int, string> _values; 

        public RomanNumber()
        {
            ConfigValues();
        }

        private void ConfigValues()
        {
            _values = new Dictionary<int, string>();
            _values.Add(1000, "M");
            _values.Add(900, "CM");
            _values.Add(500, "D");
            _values.Add(400, "CD");
            _values.Add(100, "C");
            _values.Add(90, "XC");
            _values.Add(50, "L");
            _values.Add(40, "XL");
            _values.Add(10, "X");
            _values.Add(9, "IX");
            _values.Add(5, "V");
            _values.Add(4, "IV");
            _values.Add(1, "I");
        }

        public int ToNumeral(string romanNumber)
        {
            if (EmptyRomanNumber(romanNumber))
                throw new ArgumentException("No hay número.");

            if(!IsValid(romanNumber))
                throw new ArgumentException("Romano (" + romanNumber + ") is not valid.");

            int result = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (romanNumber.Length == 1)
                {
                    result += GetKeyOfValue(romanNumber[i].ToString());
                }
                else if (i < romanNumber.Length - 1)
                {
                    string pair = romanNumber[i].ToString() + romanNumber[i + 1].ToString();
                    int val = GetKeyOfValue(pair);
                    if (val > 0)
                    {
                        result += GetKeyOfValue(pair);
                        i++;
                    }
                    else
                    {
                        result += GetKeyOfValue(romanNumber[i].ToString());
                    }
                }
                else
                {
                    result += GetKeyOfValue(romanNumber[i].ToString());                    
                }
            }

            return result;
        }

        private bool IsValid(string romanNumber)
        {
            Regex regex = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            return regex.IsMatch(romanNumber);
        }

        private int GetKeyOfValue(string letter)
        {
            int val = 0;
            foreach(int _key in _values.Keys)
            {
                if(_values[_key] == letter)
                {
                    val = _key;
                    break;
                }
            }
            return val;
        }

        private bool EmptyRomanNumber(string romanNumber)
        {
            return (romanNumber == string.Empty);
        }

        public string ToRoman(int numeral)
        {
            StringBuilder builder = new StringBuilder();

            int numAux = numeral;
            foreach (int key in _values.Keys)
            {
                while(numAux >= key)
                {
                    builder.Append(_values[key]);
                    numAux -= key;
                }
            }

            return builder.ToString();
        }
    }
}
