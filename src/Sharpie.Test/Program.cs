using System;
using System.IO;
using Sharpie.Models;
using Sharpie.Models.Elements;

namespace Sharpie.Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            var elements = new Html
            {
                ChildNode = new Head
                {
                    SiblingNode = new Body
                    {
                        ChildNode = new H1
                        {
                            ChildNode = new TextElement { Content = "Heading 1"},
                            SiblingNode = new H2
                            {
                                ChildNode = new TextElement{ Content = "Heading 2"},
                                SiblingNode = new H3
                                {
                                    ChildNode = new TextElement{ Content = "Heading 3"},
                                    SiblingNode = new H4
                                    {
                                        ChildNode = new TextElement{ Content = "Heading 4"},
                                        SiblingNode = new H5
                                        {
                                            ChildNode = new TextElement{ Content = "Heading 5"},
                                            SiblingNode = new H6
                                            {
                                                ChildNode = new TextElement{ Content = "Heading 6"},
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var output = elements.Render();
            Console.WriteLine(output);
            File.WriteAllText("/Users/hevey/Documents/index.html", output);
        }
    }
}