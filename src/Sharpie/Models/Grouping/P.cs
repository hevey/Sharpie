using Sharpie.Models;

public class P : HtmlElement
{
    private string? _content;

    public override string? Render()
    {
        _content = ChildNode?.Render();
        _content = _content != null ? $"<p{GetAttributes()}>{_content}</p>" : $"<p{GetAttributes()} />";
        
        return _content + SiblingNode?.Render();
    }
}