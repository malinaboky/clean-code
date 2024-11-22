using Markdown.Enums;

namespace Markdown.Tokens;

public class ParagraphToken : Token
{
    public override TagWrapper TagWrapper => TagWrapper.H1;
    public override string StartSeparator => "# ";
    public override string EndSeparator => "\\n";
    public override bool HasSingleSeparator => true;
    public override bool MayContainOtherTokens => true;
}