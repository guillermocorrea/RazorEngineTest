using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorEngine;
using System.IO;

namespace RazorEngineTest
{
    class Program
    {
        public static string getTemplate()
        {
            var model = new EmailModel { Name = "World", Email = "someone@somewhere.com" };
            string template = File.OpenText("templates/template.cshtml").ReadToEnd();
            Razor.Compile<EmailModel>(template, "complex");
            return Razor.Parse(template, model);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(getTemplate());
            Console.ReadLine();
        }
    }

    public class EmailModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}