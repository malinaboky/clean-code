using Markdown.Enums;

namespace Markdown.Tokens;

public abstract class Token
{
    public abstract TagWrapper TagWrapper { get; }
    public abstract string StartSeparator { get; }
    public abstract string EndSeparator { get; }
    public abstract bool HasSingleSeparator { get; }
    public abstract bool MayContainOtherTokens { get; } 
    public string Content { get; }
    public List<Token> ChildrenTokens { get; } = [];
}