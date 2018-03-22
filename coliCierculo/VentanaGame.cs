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
        Cuadro player1 = new Cuadro();
        Cuadro player2 = new Cuadro();
        Cuadro obstacle = new Cuadro();

        circulo bola = new circulo();

        punto uno = new punto(6,6,0);

        punto p1One = new punto(1, 0, 0);
        punto p1Two = new punto(3, 1, 0);
        
        
        
        punto p2One = new punto(1, 9, 0);
        punto p2Two = new punto(3, 10, 0);

        punto obsOne = new punto(0,5,0);
        punto obsTwo = new punto(10,5.5,0);
        
        punto color = new punto(1,1,1);
        punto color2 = new punto(0, 0, 0);
        Colision col = new Colision();
        

        int p1=0;
        int p2 = 0;
        
        bool startgame = false;
        bool derecha=true;
        bool arriba = true;
        bool gameover = false;
        double r = 0.5;

   

        public VentanaGame(int ancho, int alto)
            : base(ancho, alto)
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (e.KeyChar)
            {
                case 'w':
                    if (p1Two.y <= 10)
                    {
                        p1One.y += 0.1;
                        p1Two.y += 0.1;
                    }

                    break;
                    case 's':
                    if (p1One.y >=0)
                    {
                        p1One.y -= 0.1;
                        p1Two.y -= 0.1;
                    }
                    break;


                case '8':
                    if (p2Two.y <= 10)
                    {
                        p2One.y += 0.1;
                        p2Two.y += 0.1;
                    }
                    break;
                case '2':
                    if (p2One.y >= 0)
                    {
                        p2One.y -= 0.1;
                        p2Two.y -= 0.1;
                    }
                    break;

                case ' ':
                    //Console.WriteLine("spacebar");
                    startgame = true;
                    gameover = false;
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
            GL.ClearColor(0f, 0f, 0f, 0f);

        }

        

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);


            if(!gameover)
            {
            if (startgame)
            {

                if (derecha)
                {

                    if (!col.checarcolision(player2, bola))
                    {
                        uno.x += 0.1;
                        derecha = true;
                        if (arriba)
                        {
                            uno.y += 0.1f;
                            if (uno.y >= 10)
                            {
                                arriba = false;
                            }
                        }
                        if (!arriba)
                        {
                            uno.y -= 0.1f;
                            if (uno.y <= 0)
                            {
                                arriba = true;
                            }
                        }

                    }

                    if (col.checarcolision(player2, bola))
                    {
                        if (player2.Medio < uno.y)
                        {
                            arriba = true;
                        }
                        if (player2.Medio > uno.y)
                        {
                            arriba = false;
                        }

                        derecha = false;
                    }

                }


                if (!derecha)
                {


                    if (!col.checarcolision(player1, bola))
                    {
                        uno.x -= 0.1;
                        derecha = false;
                        if (arriba)
                        {
                            uno.y += 0.1f;
                            if (uno.y >= 10)
                            {
                                arriba = false;
                            }
                        }
                        if (!arriba)
                        {
                            uno.y -= 0.1f;
                            if (uno.y <= 0)
                            {
                                arriba = true;
                            }
                        }

                    }
                    if (col.checarcolision(player1, bola))
                    {
                        if (player1.Medio < uno.y)
                        {
                            arriba = true;
                        }
                        if (player1.Medio > uno.y)
                        {
                            arriba = false;
                        }

                        derecha = true;
                    }
                }


                if (bola.Derecha >= 9.5)
                {
                    p1++;
                    Console.Clear();
                    Console.WriteLine("Marcador P1: {0} p2: {1}",p1,p2);
                   
                    uno.x =player1.Derecha+r;
                    uno.y = player1.Medio;
                    startgame = false;
                  
                }
                if (bola.Izquierda <= 0.5)
                {
                    p2++;
                    Console.Clear();
                    Console.WriteLine("Marcador P1: {0} p2: {1}", p1, p2);

                    uno.x = player2.Izquierda - r; ;
                    uno.y = player2.Medio;
                    startgame = false;
                }
            }
            }

            if (p1 >= 5 || p2 >= 5)
            {
                Console.Clear();
                Console.WriteLine("gameover");
                p1 = 0;
                p2 = 0;
                gameover = true;
            }



            //col.playersCol(player1, player2, bola);

            bola.dibuja(uno, r, color);
            player1.Imprime(p1One,p1Two,color);
            player2.Imprime(p2One, p2Two,color);
            obstacle.Imprime(obsOne, obsTwo,color);


            this.SwapBuffers();
        }

        
    }
}
