using System;
using System.Collections.Generic;

namespace Sharpie.Models
{
    public class Html : HtmlElement
    {
        [Attribute]
        public string? Xmlns;
        
        private string? _content;

        public Html()
        {
            AllowedChildTypes = new List<Node>
            {

            };
        }
        
        public override string? Render()
        {
            if (!IsChildAllowed(ChildNode))
            {
                throw new InvalidOperationException("");
            }
            _content = ChildNode?.Render();
            _content = _content != null ? $"<html>{_content}</html>" : "<html></html>";
        
            return _content;
        }
    }
}