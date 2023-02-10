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
        public int MaxNumUneqSym(string inputStr)
        {
            int result = 0;
            int currNumberOfUneqCh = 0;
            inputStr = inputStr[0] + inputStr + inputStr[inputStr.Length - 1];

            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                if (inputStr[i] != inputStr[i + 1])
                {
                    currNumberOfUneqCh++;
                }
                else
                {
                    currNumberOfUneqCh++;
                    if (result < currNumberOfUneqCh)
                    {
                        result = currNumberOfUneqCh;
                    }
                    currNumberOfUneqCh = 0;
                }
            }

            return result;
        }

        public int MaxNumEqLatinLetters(string inputStr)
        {
            int result = 0;

            string latinLetters = "abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            result = MaxNumEqCh(inputStr, latinLetters);
            return result;
        }

        public int MaxNumEqDigits(string inputStr)
        {
            int result = 0;
            string digits = "1234567890";

            result = MaxNumEqCh(inputStr, digits);

            return result;
        }

        private int MaxNumEqCh(string inputStr, string setOfChars)
        {
            int result = 0;
            int currNumberOfUneqCh = 0;
            char firstCh = '.';
            char lastCh = '.';

            if (inputStr[0] == firstCh)
            {
                firstCh = ',';
            }

            if (inputStr[inputStr.Length - 1] == lastCh)
            {
                lastCh = ',';
            }

            inputStr = firstCh + inputStr + lastCh;

            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                if (inputStr[i] == inputStr[i + 1] )
                {
                    result++;
                }
                else
                {
                    if (setOfChars.Contains(inputStr[i]))
                    {
                        result++;
                        if (currNumberOfUneqCh < result)
                        {
                            currNumberOfUneqCh = result;
                        }
                    }
                    result = 0;
                }
            }

            if (currNumberOfUneqCh > result)
            {
                result = currNumberOfUneqCh;
            }

            return result;
        }
    }
}
