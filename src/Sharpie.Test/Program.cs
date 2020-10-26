using System;
using Sharpie.Models;

namespace Sharpie.Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            var elements = new Html
            {
                ChildNode = new P
                {
                    Class = "test test2 test3",
                    Id = "p",
                    ChildNode = new TextElement
                    {
                        Content = "I am child of P1"
                    },
                    SiblingNode = new P
                    {
                        ChildNode = new TextElement
                        {
                            Content = "I am child of P2"
                        },
                        SiblingNode = new P()
                    }
                }
            };

            var output = elements.Render();
            Console.WriteLine(output);
        }
    }
}