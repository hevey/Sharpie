using Sharpie.Models;

public class P : HtmlNode
{
    private string? _content;
    
    public override string? Render()
    {
        _content = ChildNode?.Render();
        _content = _content != null ? $"<p>{_content}</p>" : "<p />";
        
        return _content + SiblingNode?.Render();
    }
}