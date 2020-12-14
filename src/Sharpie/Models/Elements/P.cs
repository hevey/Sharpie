namespace Sharpie.Models.Elements
{
    public class P : HtmlElement
    {

        public override string Render()
        {
            Content = ChildNode?.Render();
            Content = Content != null ? $"<p{GetAttributes()}>{Content}</p>" : $"<p{GetAttributes()} />";
        
            return Content + SiblingNode?.Render();
        }
    }
}