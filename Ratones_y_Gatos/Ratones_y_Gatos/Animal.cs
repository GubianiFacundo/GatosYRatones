using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    abstract class Animal
    {
        protected string tipo;
        public int pasosSinComida { get; set; }
        protected int diasVividos { get; set; }
        public int genero;
        public int posX { get; set; }
        public int posY { get; set; }
        protected int cont = 0;
        public bool seReprodujo = false;
        protected static Random r = new Random();

       public Animal(int x, int y)
        {
            pasosSinComida = 0;
            diasVividos = 0;
            posX = x;
            posY = y;
        }

        public void Mover()  
        {
            if (r.Next(2)==1)
                posX += r.Next(-3, 4);
            else
                posY += r.Next(-3, 4);

            seReprodujo = false;
            diasVividos++;
        }

        public virtual void Comer(ArrayList objs)
        { }

       
       
    }
}
