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
        double Arr;
        double Aba;
        double med;

        public Cuadro()
        {
            Der = 0;
            Izq = 0;
            Arr = 0;
            Aba = 0;
            med = 0;
        }

        public void Imprime(punto a, punto b,punto color)
        {
            Der = a.x+b.x;
            Izq = a.x;
            Arr = a.y+b.y;
            Aba = a.y;
            med = Arr / 2;

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.x, color.y, color.z);
            GL.Vertex2(a.x, a.y);
            GL.Vertex2(b.x, a.y);
            GL.Vertex2(b.x, b.y);
            GL.Vertex2(a.x, b.y);
            GL.End();
        }
        public double Derecha
        {
            get { return Der; }
        }
        public double Izquierda
        {
            get { return Izq; }
        }
        public double Arriba
        {
            get { return Arr; }
        }
        public double Abajo
        {
            get { return Aba; }
        }
        public double Medio
        {
            get { return med; }
        }
    }
}
