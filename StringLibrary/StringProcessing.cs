using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Formats.Asn1;
using System.Xml;

namespace StringLibrary
{
    public class StringProcessing
    {
        public int MaxNumberUnequalSymbols(string inputString)
        {
            int result = 0;
            int currentNumberOfUnequalCharacters = 0;

            inputString = inputString[0] + inputString + inputString[inputString.Length - 1];

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    currentNumberOfUnequalCharacters++;
                }
                else
                {
                    currentNumberOfUnequalCharacters++;

                    if (result < currentNumberOfUnequalCharacters)
                    {
                        result = currentNumberOfUnequalCharacters;
                    }

                    currentNumberOfUnequalCharacters = 0;
                }
            }

            return result;
        }

        public int MaxNumberEqualLatinLetters(string inputString)
        {
            int result = 0;

            string latinLetters = "abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            result = MaxNumberEqualChars(inputString, latinLetters);
            return result;
        }

        public int MaxNumberEqualDigits(string inputString)
        {
            int result = 0;
            string digits = "1234567890";

            result = MaxNumberEqualChars(inputString, digits);

            return result;
        }

        private int MaxNumberEqualChars(string inputString, string setOfChars)
        {
            int result = 0;
            int currentNumberOfUnequalCharacters = 0;
            char firstChar = '.';
            char lastChar = '.';

            if (inputString[0] == firstChar)
            {
                firstChar = ',';
            }

            if (inputString[inputString.Length - 1] == lastChar)
            {
                lastChar = ',';
            }

            inputString = firstChar + inputString + lastChar;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1] )
                {
                    result++;
                }
                else
                {
                    if (setOfChars.Contains(inputString[i]))
                    {
                        result++;

                        if (currentNumberOfUnequalCharacters < result)
                        {
                            currentNumberOfUnequalCharacters = result;
                        }
                    }

                    result = 0;
                }
            }

            if (currentNumberOfUnequalCharacters > result)
            {
                result = currentNumberOfUnequalCharacters;
            }

            return result;
        }
    }
}
