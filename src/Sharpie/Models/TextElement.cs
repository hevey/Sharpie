namespace Sharpie.Models
{
    public class TextElement : Element
    {
        public string? Content { get; set; }
        public override string? Render()
        {
            return Content;
        }
    }
}