namespace Sharpie.Models.Elements
{
    public class H6 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h6{GetAttributes()}>{Content}</h6>" : $"<h6{GetAttributes()}></h6>";
        
            return Content + SiblingNode?.Render();
        }
    }
}