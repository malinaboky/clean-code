using Markdown.Enums;

namespace Markdown.Tokens;

public class LiteralToken : Token
{
    public override TagWrapper TagWrapper => TagWrapper.None;
    public override string StartSeparator => "";
    public override string EndSeparator => "";
    public override bool HasSingleSeparator => false;
    public override bool MayContainOtherTokens => true;
}