namespace Sharpie.Models
{
    public class TextElement : Node
    {
        public string? Content { get; set; }
        public override string? Render()
        {
            return Content;
        }
    }
}