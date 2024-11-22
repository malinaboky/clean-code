using Markdown.Enums;

namespace Markdown.Tokens;

public class ItalicsToken : Token
{
    public override TagWrapper TagWrapper => TagWrapper.Em;
    public override string StartSeparator => "_";
    public override string EndSeparator => "_";
    public override bool HasSingleSeparator => false;
    public override bool MayContainOtherTokens => false;
}