using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace coliCierculo
{
    class Cuadro
    {
        double Der;
        double Izq;
        double Arriba;
        double Abajo;

        public Cuadro()
        {
            Der = 0;
            Izq = 0;
            Arriba = 0;
            Abajo = 0;
        }

        public void Imprime(punto a, punto b)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(a.x, a.y);
            GL.Vertex2(b.x, a.y);
            GL.Vertex2(b.x, b.y);
            GL.Vertex2(a.x, b.y);
            GL.End();
        }
    }
}
