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

            for (int i = 1; i < inputStr.Length; i++)
            {
                if (inputStr[i] != inputStr[i - 1])
                {
                    currNumberOfUneqCh++;
                }
                else
                {
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

            for (int i = 1; i < inputStr.Length; i++)
            {
                if (inputStr[i] == inputStr[i - 1] &&
                    setOfChars.Contains(inputStr[i]))
                {
                    currNumberOfUneqCh++;
                }
                else
                {
                    if (result < currNumberOfUneqCh)
                    {
                        result = currNumberOfUneqCh;
                    }
                    currNumberOfUneqCh = 0;
                }
            }
            return result;
        }
    }
}
