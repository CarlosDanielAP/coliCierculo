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
        punto primer = new punto(0, 0,0);
        punto segundo = new punto(1, 1,0);

        punto tres = new punto(4, 4,0);
        punto cuatro = new punto(5, 5,0);

        punto color1 = new punto(0f, 0f, 0f);
        punto color2= new punto(1f,1f,1f);
        Colision colisionador= new Colision();

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
                     
                      if (colisionador.checarcolision(cuadrito, cuadrito2))
                      {
                          color1.valores(0f, 0f, 0f);
                      }
                      break;
                  case 'a':
                     
                      if (colisionador.checarcolision(cuadrito, cuadrito2))
                      {
                          color1.valores(0f, 0f, 0f);
                      }

                      else
                      {
                          color1.valores(1f, 1f, 1f);
                      }
                      break;
                  case 'w':
                      
                      if (colisionador.checarcolision(cuadrito, cuadrito2))
                      {
                          color1.valores(0f, 0f, 0f);
                      }
                      else
                      {
                          color1.valores(1f, 1f, 1f);
                      }
                      break;
                  case 's':
                      
                      if (colisionador.checarcolision(cuadrito, cuadrito2))
                      {
                          color1.valores(0f, 0f, 0f);
                      }
                      else
                      {
                          color1.valores(1f, 1f, 1f);
                      }
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

            cuadrito.Imprime(primer, segundo,color1);
            cuadrito2.Imprime(tres, cuatro,color2);
            colisionador.checarcolision(cuadrito, cuadrito2);

           
            segundo.y = primer.y + 1;


            this.SwapBuffers();
        }

        
    }
}
