using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coliCierculo
{
    class Colision
    {
        bool p1col;
        bool p2col;

        public Colision()
        {
            p1col = false;
            p2col = false;
          
        }



        public void playersCol(Cuadro player1, Cuadro player2, circulo pelota) {



            if (pelota.Centro >= player2.Izquierda)
            {
                p2col = true;

            }
            else
                p2col = false;


            if (pelota.Centro <= player1.Izquierda )
            {
                p1col = true;

            }
            else
                p1col = false;
        }

        public bool checarcolision(Cuadro player,circulo pelota)
        {

            if (pelota.Centro >= player.Derecha)
            {
                
                
                return false;
            }
            
           


            if (pelota.Centro <= player.Izquierda)
            {


                return false;
            }

            return true;
        }




        public bool P1col
        {
            get { return p1col; }
        }

      
        public bool P2col
        {
            get { return p2col; }
        }
    }
}

    
