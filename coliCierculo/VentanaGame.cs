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
        Cuadro cuadrito2 = new Cuadro();
        punto primer = new punto(0, 0);
        punto segundo = new punto(1, 1);
        punto tres = new punto(5, 5);
        punto cuatro = new punto(4, 4);
        public VentanaGame(int ancho, int alto)
            : base(ancho, alto)
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        { 
              base.OnKeyPress(e);
              switch (e.KeyChar)
              {
                  case 'd':
                      primer.x += 0.1;
                      segundo.x = primer.x + 1;
                      break;
                  case 'a':
                      primer.x -= 0.1;
                      segundo.x = primer.x + 1;
                      break;
                  case 'w':
                      primer.y += 0.1;
                      segundo.y = primer.y + 1;
                      break;
                  case 's':
                      primer.y -= 0.1;
                      segundo.y = primer.y + 1;
                      break;
              
              }
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

            cuadrito.Imprime(primer, segundo);
            cuadrito2.Imprime(tres, cuatro);

            this.SwapBuffers();
        }

        
    }
}
