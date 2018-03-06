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
          
        }



        public void playersCol(Cuadro player1, Cuadro player2, circulo pelota) {
            if (player1.Derecha >= pelota.Centro)
            {
                p1col = true;
            }
            else
                p1col = false;

            if (player1.Derecha >= pelota.Centro)
            {
                p1col = true;
            }
            else
                p1col = false;
           
           

        
        
        }

        public bool checarcolision(Cuadro player1,Cuadro player2, circulo pelota)
        {

            if (pelota.Centro >= player1.Derecha)
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

    
