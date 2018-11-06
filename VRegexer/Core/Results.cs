/**
 * VRegexer
 * Copyright (C) Simon Raichl 2018
 * MIT License
 * Use this as you want, share it as you want, do basically whatever you want with this :)
 */

using System;
using System.Text.RegularExpressions;

namespace VRegexer
{
    class Results
    {
        public int count;
        public string allMatchesAsString = ""; 

        public Results(MatchCollection matches)
        {
            count = matches == null ? 0 : matches.Count;
            if (matches != null)
            {
                foreach (Match match in matches)
                {
                    allMatchesAsString += match + Environment.NewLine;
                }
            }
        }
    }
}
