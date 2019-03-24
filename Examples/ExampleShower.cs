using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class ExampleShower
    {
        static void Main()
        {
            List<string> exampleList = new List<string>
                {
                "Params"

                };
            Console.WriteLine("Wellcome to the examples, you can pick these examples to see:");
            foreach (var example in exampleList)
            {
                Console.WriteLine($"{example}");
            }
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input.Equals("params", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("This is the params example:");
                    var param = new ParamsExample();
                    param.Execute();
                    Console.WriteLine("That is the output of the params example, look in the code for more.");
                    Console.ReadLine();
                }
            }
        }
    }
}