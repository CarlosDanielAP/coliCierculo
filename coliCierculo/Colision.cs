using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coliCierculo
{
    class Colision
    {
        public void colision()
        {

        }
        public bool checarcolision(Cuadro a, Cuadro b)
        {
            if (a.Derecha <= b.Izquierda)
            {
                
                return false;
            }
            if (a.Izquierda >= b.Derecha)
            {
                return false;
            }
            if (a.Abajo >= b.Arriba)
            {
                return false;
            }

            if (a.Arriba <= b.Abajo)
            {
                return false;
            }
           
                
                return true;
           
            

        }
    }
}
