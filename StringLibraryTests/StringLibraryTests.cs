using Xunit;
using StringLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary.Tests
{
    public class StringLibraryTests
    {
        [Theory()]
        [InlineData("aaa", 1)]
        [InlineData("aba", 3)]
        [InlineData("aabff", 3)]
        [InlineData("aabf", 3)]
        [InlineData("abffff", 3)]
        public void MaxNumUneqSymTest(string input, int expected)
        {
            //Arrange
            var strPr = new StringProcessing();
            //Act
            int result = strPr.MaxNumUneqSym(input);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory()]
        [InlineData("ffaaa", 3)]
        [InlineData("ffaaab", 3)]
        [InlineData("aaa1111", 3)]
        [InlineData("1111", 0)]
        [InlineData("aaa", 3)]
        public void MaxNumEqLatinLettersTest(string input, int expected)
        {
            //Arrange
            var strPr = new StringProcessing();
            //Act
            int result = strPr.MaxNumEqLatinLetters(input);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory()]
        [InlineData("111aaaa", 3)]
        [InlineData("1112222", 4)]
        [InlineData("aaa", 0)]
        [InlineData("333", 3)]
        public void MaxNumEqDigitsTest(string input, int expected)
        {
            //Arrange
            var strPr = new StringProcessing();
            //Act
            int result = strPr.MaxNumEqDigits(input);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}