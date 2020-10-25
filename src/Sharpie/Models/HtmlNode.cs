using System.Collections.Generic;

namespace Sharpie.Models
{
    public abstract class HtmlNode: Element
    {
        [Attribute]
        public string AccessKey;
        [Attribute]
        public string Class;
        [Attribute]
        public string ContentEditable;
        [Attribute]
        public string Data;
        [Attribute]
        public string Dir;
        [Attribute]
        public string Draggable;
        [Attribute]
        public string Hidden;
        [Attribute]
        public string Id;
        [Attribute]
        public string Lang;
        [Attribute]
        public string SpellCheck;
        [Attribute]
        public string Style;
        [Attribute]
        public string TabIndex;
        [Attribute]
        public string Title;
        [Attribute]
        public string Translate;
        
        public Element? SiblingNode;
        public Element? ChildNode;
        
    }
}
