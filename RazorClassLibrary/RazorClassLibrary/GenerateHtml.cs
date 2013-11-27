using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    public static class GenerateHtml
    {
        /// <summary>
        /// Generate order Html
        /// </summary>
        /// <returns></returns>
        public static string ForOrder()
        {
            var order = new OrderModel();
            var template = GetTemplate("RazorClassLibrary.OrderTemplate.cshtml");

            // parse template using RazorEngine
            var html = RazorEngine.Razor.Parse(template, order);

            return html;
        }

        /// <summary>
        /// Read an embedded resource as a string
        /// </summary>
        private static string GetTemplate(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new System.IO.StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
