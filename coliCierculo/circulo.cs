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
        double cent;
        public circulo(){
            cent = 0;

        }

        public void dibuja(punto a, double radio,punto color)
        {
            cent = a.x;


            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(color.x, color.y, color.z);
           
            for(double i=0;i< Math.PI * 2; i += 0.3)
            {
                GL.Vertex2(a.x + (Math.Cos(i)*radio) , a.y + (Math.Sin(i) * radio));
            }
            GL.End();
        }

        public double Centro
        {
            get { return cent; }
        }
    }
}
