using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Queso
    {
        public int posX;
        public int posY;
        public int cantidad;

        public Queso(int x, int y)
        {
            posX = x;
            posY = y;
            cantidad = 2;
        }

        public Queso(int x, int y,int cant)
        {
            posX = x;
            posY = y;
            cantidad = cant;
        }

        public int AddQueso(int cant)
        {
            cantidad += cant;
            return cantidad;
        }

        public override string ToString()
        {
            return "Queso: X:" + posX + " Y:" + posY + "  Cantidad:" + cantidad;
        }
    }
}
