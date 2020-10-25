namespace Sharpie.Models
{
    [System.AttributeUsage(System.AttributeTargets.Field)]
    public class Attribute : System.Attribute
    {
        public bool Required;

        public Attribute()
        {
            Required = false;
        }
    }
}