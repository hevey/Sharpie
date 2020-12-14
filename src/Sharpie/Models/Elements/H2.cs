namespace Sharpie.Models.Elements
{
    public class H2 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h2{GetAttributes()}>{Content}</h2>" : $"<h2{GetAttributes()}></h2>";
        
            return Content + SiblingNode?.Render();
        }
    }
}