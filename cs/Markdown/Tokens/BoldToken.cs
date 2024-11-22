using Markdown.Enums;

namespace Markdown.Tokens;

public class BoldToken : Token
{
    public override TagWrapper TagWrapper => TagWrapper.Strong;
    public override string StartSeparator => "__";
    public override string EndSeparator => "__";
    public override bool HasSingleSeparator => false;
    public override bool MayContainOtherTokens => true;
}