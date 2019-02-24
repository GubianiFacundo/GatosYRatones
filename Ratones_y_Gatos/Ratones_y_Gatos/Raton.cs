using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Raton : Animal
    {       
        public Raton(int x, int y)
            : base(x,y)
        {
            this.tipo = "Ratón";
            this.genero = r.Next(2);
        }
    
        public override void Comer(ArrayList objs)
        {
            bool comio = false;
            for(int i=0;i<objs.Count;i++)
            {
                if (objs[i] is Queso)
                {
                    if (posX == ((Queso)objs[i]).posX && posY == ((Queso)objs[i]).posY)
                    {
                        if (cont != 2)
                        {
                            pasosSinComida = 0;
                            ((Queso)objs[i]).cantidad--;
                            if (((Queso)objs[i]).cantidad == 0)
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
            return "Raton: "+"x:"+posX+"- y:"+posY+" Pasos Sin Comer:"+pasosSinComida+" Dias Vividos:"+diasVividos/10+" Genero:"+genero;
        }
        

    }
}
