namespace Sharpie.Models.Elements
{
    public class H5 : HtmlElement
    {
        public override string? Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<h5{GetAttributes()}>{Content}</h5>" : $"<h5{GetAttributes()}></h5>";
        
            return Content + SiblingNode?.Render();
        }
    }
}