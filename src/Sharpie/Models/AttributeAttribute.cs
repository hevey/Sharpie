namespace Sharpie.Models
{
    [System.AttributeUsage(System.AttributeTargets.Field)]
    public class AttributeAttribute : System.Attribute
    {
        public bool Required;

        public AttributeAttribute()
        {
            Required = false;
        }
    }
}