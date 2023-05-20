using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To the Math Game , Where you choose type of Game and answer questions accordingly");
            var game = new Runner();
            game.Run();
        }
    }
}
