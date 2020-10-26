namespace Sharpie.Models
{
    public class Html : HtmlElement
    {
        public string? xmlns;
        
        private string? _content;
        
        public override string? Render()
        { 
            _content = ChildNode?.Render();
            _content = _content != null ? $"<html>{_content}</html>" : "<html></html>";
        
            return _content;
        }
    }
}