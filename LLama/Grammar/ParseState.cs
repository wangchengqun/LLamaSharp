﻿using LLama.Native;
using System;
using System.Collections.Generic;

namespace LLama.Grammar
{
    /// <summary>
    /// Source:
    /// https://github.com/ggerganov/llama.cpp/blob/6381d4e110bd0ec02843a60bbeb8b6fc37a9ace9/common/grammar-parser.h
    /// 
    /// The commit hash from URL is the actual commit hash that reflects current C# code.
    /// </summary>
    public class ParseState
    {
        public SortedDictionary<string, uint> SymbolIds { get; } = new SortedDictionary<string, uint>();
        public List<List<LLamaGrammarElement>> Rules { get; } = new List<List<LLamaGrammarElement>>();

        public IEnumerable<List<LLamaGrammarElement>> CRules()
        {
            foreach (var rule in Rules)
            {
                yield return rule;
            }
        }
    }
}
