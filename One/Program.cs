using One.Models;
using System;
using System.Text;

namespace One
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Deanery deanery = new Deanery("Программирования", "33", "1", "88005553535", "Иванов");
            Console.WriteLine(deanery.ToString());
        }
    }
}
