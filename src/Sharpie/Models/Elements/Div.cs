namespace Sharpie.Models.Elements
{
    public class Div : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<div{GetAttributes()}>{Content}</div>" : $"<div{GetAttributes()}></div>";
        
            return Content + SiblingNode?.Render();
        }
    }
}