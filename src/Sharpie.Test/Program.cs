using System;
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
                ChildNode = new Head()
            };

            var output = elements.Render();
            Console.WriteLine(output);
        }
    }
}