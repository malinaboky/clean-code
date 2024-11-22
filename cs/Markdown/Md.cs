﻿using Markdown.Renderers;
using Markdown.Tokenizers;

namespace Markdown;

public class Md
{
    private readonly ITokenizer tokenizer;
    private readonly ITokenConverter tokenConverter;

    private Md(ITokenizer tokenizer, ITokenConverter tokenConverter)
    {
        this.tokenizer = tokenizer;
        this.tokenConverter = tokenConverter;
    }

    public Md Create(ITokenizer tokenizer, ITokenConverter tokenConverter)
    {
        return new Md(tokenizer, tokenConverter);
    }
    
    public string Render(string markdownStr)
    {
        var tokens = tokenizer.SplitToTokens(markdownStr);
        var convertedStr = tokenConverter.ConvertTokens(tokens);
        return convertedStr;
    }
}