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
    class VentanaGame:GameWindow
    {
        Cuadro cuadrito = new Cuadro();
        circulo bola = new circulo();

        punto uno = new punto(5,5,0);
        punto color = new punto();
        double r = 1;

        

        public VentanaGame(int ancho, int alto)
            : base(ancho, alto)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 10, 0, 10, -1, 1);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(0.5f, 0.5f, 1f, 1f);

        }

        

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

           
            for (float i = 0; i <= 15; i++)
            {
                uno.valores(5, i, 0);
                bola.dibuja(uno, r, color);
            }

            this.SwapBuffers();
        }

        
    }
}
