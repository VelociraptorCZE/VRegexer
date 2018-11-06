/**
 * VRegexer
 * Copyright (C) Simon Raichl 2018
 * MIT License
 * Use this as you want, share it as you want, do basically whatever you want with this :)
 */

using System.Text.RegularExpressions;

namespace VRegexer
{
    class Parser : IParser
    {
        public Results GetData(string pattern, string testString)
        {
            MatchCollection matches;
            try {
                matches = Regex.Matches(testString, pattern == "" ? null : @pattern);
            }
            catch {
                matches = null;
            }
            Results dataCollection = new Results(matches);
            return dataCollection;
        }
    }
}
