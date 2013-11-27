using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorClassLibrary;
using NUnit.Framework;
namespace RazorClassLibrary.Tests
{
    [TestFixture()]
    public class GenerateHtmlTests
    {
        [Test()]
        public void ForOrderTest()
        {
            // create html using template and a model
            var html = GenerateHtml.ForOrder();

            Assert.IsNotNull(html);
            // output
            Console.WriteLine(html);
        }
    }
}
