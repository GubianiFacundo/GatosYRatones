using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Gato : Animal
    {
        public Gato(int x, int y)
            : base(x, y)
        {
            this.tipo = "Gato";
            this.genero = 0;
        }

        public override void Comer(ArrayList objs)
        {
            bool comio = false;
            for (int i = 0; i < objs.Count; i++)
            {
                if (objs[i] is Raton)
                {
                    if (posX == ((Raton)objs[i]).posX && posY == ((Raton)objs[i]).posY)
                    {
                        if (cont != 1)
                        {
                            pasosSinComida = 0;
                            objs.RemoveAt(i);
                            comio = true;
                            cont++;
                        }
                    }
                }
            }
            if (!comio)
                pasosSinComida++;

            if (pasosSinComida == 10)
                cont = 0;
        }

        public override string ToString()
        {
            return "Gato: " + "x:" + posX + "- y:" + posY + " Pasos Sin Comer:" + pasosSinComida + " Dias Vividos:" + diasVividos / 10 ;
        }
    }
}
