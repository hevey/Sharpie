using System;
using Sharpie.Models;

namespace Sharpie.Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            var elements = new P
            {
                ChildNode = new TextElement
                {
                    Content = "I am child of P1"
                },
                SiblingNode = new P
                {
                    ChildNode = new TextElement
                    {
                        Content = "I am child of P2"
                    }
                }
            };

            var output = elements.Render();
            Console.WriteLine(output);
        }
    }
}