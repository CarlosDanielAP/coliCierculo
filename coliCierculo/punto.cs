using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coliCierculo
{
    class punto
    {
        private double _x;
        private double _y;

        public punto()
        {
            _x = 0;
            _y = 0;
        }

        public punto(double CoordX, double CoordY)
        {
            _x = CoordY;
            _y = CoordX;
        }

        public void valores(double CoordX, double CoordY)
        {
            _x = CoordY;
            _y = CoordX;
        }

        public double x
        {
            set { _x = value; }
            get { return _x; }
        }

        public double y
        {
            set { _y = value; }
            get { return _y; }
        }
    }
}
