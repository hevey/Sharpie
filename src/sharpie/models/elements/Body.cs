using System;

namespace Sharpie.Models.Elements
{
    public class Body: HtmlElement
    {
        public override string? Render()
        {
            if (!IsChildAllowed(ChildNode?.GetType()))
            {
                throw new InvalidOperationException($"Child of type {ChildNode?.GetType()} is not allowed");
            }

            if (!IsSiblingAllowed(SiblingNode?.GetType()))
            {
                throw new InvalidOperationException($"Sibling of type {SiblingNode?.GetType()} is not allowed");
            }
            
            Content = ChildNode?.Render();
            Content = Content != null ? $"<body>{Content}</body>" : "<body></body>";

            return Content;
        }
    }
}