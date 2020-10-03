using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace uwp
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Entities.Units.Folower("liember");
            Console.WriteLine(f.Health);
        }
    }
}
