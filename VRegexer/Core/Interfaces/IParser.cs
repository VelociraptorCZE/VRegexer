/**
 * VRegexer
 * Copyright (C) Simon Raichl 2018
 * MIT License
 * Use this as you want, share it as you want, do basically whatever you want with this :)
 */

namespace VRegexer
{
    interface IParser
    {
        Results GetData(string pattern, string testString);
    }
}
