﻿using System;
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
        private double _z;

        public punto()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public punto(double CoordX, double CoordY, double CoordZ)
        {
            _x = CoordY;
            _y = CoordX;
            _z = CoordZ;
        }

        public void valores(double CoordX, double CoordY,double CoordZ)
        {
            _x = CoordY;
            _y = CoordX;
            _z = CoordZ;
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
        public double z
        {
            set { _z = value; }
            get { return _z; }
        }
    }
}
