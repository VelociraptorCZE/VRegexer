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
    public partial class VRegexer : Form
    {
        private ICore core;

        public VRegexer()
        {
            InitializeComponent();
            core = new Core(resultsOutput);
        }

        private void RegexInputOnChange(object sender, EventArgs e) 
            => core.Match(regexInput.Text, testStringInput.Text);

        private void TestStringInputOnChange(object sender, EventArgs e)
            => core.Match(regexInput.Text, testStringInput.Text);
    }
}
