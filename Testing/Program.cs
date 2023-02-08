using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeDetective;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MimeTypes.GetFileType(System.IO.File.OpenRead(@"")));
            Console.Read();
        }
    }
}
