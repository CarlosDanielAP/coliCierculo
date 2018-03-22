using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coliCierculo
{
    class Program
    {
        static void Main(string[] args)
        {

            VentanaGame screen = new VentanaGame(600, 500);
            screen.Title = "SuperPong100%RealNoFake";
            screen.Run();
        }
    }
}
