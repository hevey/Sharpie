using System;
using System.Collections.Generic;

namespace Sharpie.Models.Elements
{
    public class Head : HtmlElement
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
            Content = Content != null ? $"<head>{Content}</head>" : "<head></head>";
            
            return Content + SiblingNode?.Render();
        }
    }
}
