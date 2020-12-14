using System;
using System.Collections.Generic;

namespace Sharpie.Models.Elements
{
    public class Html : HtmlElement
    {
        [Attribute]
        public string? Xmlns;

        public Html()
        {
            AllowedChildTypes = new List<Type>
            {
                typeof(Head)
            };
        }
        
        public override string? Render()
        {
            if (!IsChildAllowed(ChildNode?.GetType()))
            {
                throw new InvalidOperationException($"Child of type {ChildNode?.GetType()} is not allowed");
            }
            
            Content = ChildNode?.Render();
            Content = Content != null ? $"<html{GetAttributes()}>{Content}</html>" : $"<html{GetAttributes()}></html>";
        
            return Content;
        }
    }
}