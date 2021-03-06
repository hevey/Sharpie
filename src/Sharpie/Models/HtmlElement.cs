using System;
using System.Collections.Generic;

namespace Sharpie.Models
{
    public abstract class HtmlElement: Node
    {
        [Attribute]
        public string? AccessKey;
        [Attribute]
        public string? Class;
        [Attribute]
        public string? ContentEditable;
        [Attribute]
        public string? Data;
        [Attribute]
        public string? Dir;
        [Attribute]
        public string? Draggable;
        [Attribute]
        public string? Hidden;
        [Attribute]
        public string? Id;
        [Attribute]
        public string? Lang;
        [Attribute]
        public string? SpellCheck;
        [Attribute]
        public string? Style;
        [Attribute]
        public string? TabIndex;
        [Attribute]
        public string? Title;
        [Attribute]
        public string? Translate;
        
        protected string? Content;
        
        public List<Type>? AllowedChildTypes { get; init; }
        public List<Type>? AllowedSiblingTypes { get; init; }
        
        public Node? SiblingNode;
        public Node? ChildNode;

        protected string GetAttributes()
        {
            var fields = GetType().GetFields();
            var attributes = string.Empty;
            
            foreach (var fieldInfo in fields)
            {
                var attrs = fieldInfo.GetCustomAttributes(false);
                
                foreach (var attr in attrs)
                {
                    if (attr is not Attribute attribute) continue;
                    
                    var name = fieldInfo.Name.ToLower();
                    var value = fieldInfo.GetValue(this);
                    
                    if (attribute.Required && value == null)
                    {
                        throw new InvalidOperationException($"Attribute {name} is required");
                    }

                    if (value == null) continue;
                    
                    var stringAttribute = (string) value == string.Empty ? name : $"{name}='{value}'";
                    attributes += $" {stringAttribute}";

                } 
            }

            return attributes;
        }

        protected bool IsChildAllowed(Type? childNode)
        {
            return AllowedChildTypes == null || childNode != null && AllowedChildTypes.Contains(childNode);
        }
        
        protected bool IsSiblingAllowed(Type? siblingNode)
        {
            return AllowedSiblingTypes == null || siblingNode != null && AllowedSiblingTypes.Contains(siblingNode);
        }
    }
}
