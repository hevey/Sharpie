namespace Sharpie.Models.Elements
{
    public class H3 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h3{GetAttributes()}>{Content}</h3>" : $"<h3{GetAttributes()}></h3>";
        
            return Content + SiblingNode?.Render();
        }
    }
}