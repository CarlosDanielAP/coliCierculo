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
    class circulo
    {
        double Der;
        double Izq;
        double Arr;
        double Aba;
        public circulo(){
            Der = 0;
            Izq = 0;
            Arr = 0;
            Aba = 0;

        }

        public void dibuja(punto a, double radio,punto color)
        {
            Der = a.x + radio;
            Izq = a.x - radio;
            Arr = a.y + radio;
            Aba = a.y - radio;


            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(color.x, color.y, color.z);
           
            for(double i=0;i< Math.PI * 2; i += 0.3)
            {
                GL.Vertex2(a.x + (Math.Cos(i)*radio) , a.y + (Math.Sin(i) * radio));
            }
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
    }
}
