using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = InputConverter.ConvertInput(args);
            Console.WriteLine(output);
        }
    }

    public static class InputConverter
    {
        public static string ConvertInput(string[] args)
        {
            FileDetails fd = new FileDetails();

            string str = args[0].Replace("-", "").Replace("/", "").ToLower();
            if (str.StartsWith("v"))
                Console.WriteLine("Version: " + fd.Version(args[1]));
            else if (str.StartsWith("s"))
                Console.WriteLine("Size: " + fd.Size(args[1]));
            Console.ReadKey();
            return fd.Version(args[1]).ToString();

        }
    }
}

  
