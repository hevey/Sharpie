namespace Sharpie.Models.Elements
{
    public class H4 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h4{GetAttributes()}>{Content}</h4>" : $"<h4{GetAttributes()}></h4>";
        
            return Content + SiblingNode?.Render();
        }
    }
}