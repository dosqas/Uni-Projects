﻿using System;

namespace cs_a1a2
{
    // We use this class to separate out string into tokens/words.
    internal class SeparateStringInWords
    {
        public string[] SeparatingString(string inputString)
        {
            // We define our array of char delimiters as space, newline and tab, as per the requirements.
            char[] delimiters = new char[] {' ', '\n', '\t'};

            // We use the Split method to split our string into tokens, using as parameters the delimiters
            // alongside putting the option of removing the entries which are empty.
            return inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
