/**
 * VRegexer
 * Copyright (C) Simon Raichl 2018
 * MIT License
 * Use this as you want, share it as you want, do basically whatever you want with this :)
 */

using System;
using System.Windows.Forms;

namespace VRegexer
{
    class Core : ICore
    {
        private TextBox output;

        public Core(TextBox output) => this.output = output;

        public void Match(string pattern, string testString)
        {
            Results res = new Parser().GetData(pattern, testString);
            output.Text = "Number of all matches: " + res.count + Environment.NewLine + res.allMatchesAsString;
        }
    }
}
