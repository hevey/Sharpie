namespace Sharpie.Models.Elements
{
    public class H1 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h1{GetAttributes()}>{Content}</h1>" : $"<h1{GetAttributes()}></h1>";
        
            return Content + SiblingNode?.Render();
        }
    }
}