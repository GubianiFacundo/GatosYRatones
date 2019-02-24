using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Manager
    {
        public int W;
        public int H;
        public ArrayList animales = new ArrayList();
        public ArrayList quesos = new ArrayList();
        static Random r = new Random();

        public Manager(bool conGatos, int x, int y, int cantR, int cantG)
        {
            W = x;
            H = y;

            for (int i = 0; i < cantR; i++)
            animales.Add(new Raton(r.Next(W), r.Next(H)));
            
            for (int i = 0; i < cantR / 2; i++)
                quesos.Add(new Queso(r.Next(W), r.Next(H)));

            if (conGatos)
                for (int i = 0; i < cantG; i++)
                    animales.Add(new Gato(r.Next(W), r.Next(H)));

        }

        public void checkRatones()
        {
            for (int i = animales.Count - 1; i >= 0; i--)
            {
                if (animales[i] is Raton)
                { 
                Raton rat1 = (Raton)animales[i];

                for (int j = animales.Count - 1; j >= 0; j--)
                {
                      if (animales[j] is Raton)
                      {
                    Raton rat2 = (Raton)animales[j];

                    if (rat1.posX == rat2.posX && rat1.posY == rat2.posY
                        && i!=j
                        && rat1.genero != rat2.genero
                        && rat1.seReprodujo == false && rat2.seReprodujo == false)
                    {
                       
                                    rat1.seReprodujo = true;
                                    rat2.seReprodujo = true;
                                    int ratasNuevas = r.Next(2, 7);
                                    for (int k = 0; k < ratasNuevas ; k++)
                                        animales.Add(new Raton(r.Next(W), r.Next(H)));
                                    for (int k = 0; k < ratasNuevas / 2; k++)
                                    {
                                                
                                     Queso q= new Queso(r.Next(W), r.Next(H));
                                     for (int h = 0; h < quesos.Count; h++)
                                     {
                                         if (q.posX == ((Queso)quesos[h]).posX && q.posY == ((Queso)quesos[h]).posY)
                                             ((Queso)quesos[h]).AddQueso(2);
                                     }
                                     quesos.Add(q);
                                    }

                                    Queso queso;
                                    if (ratasNuevas % 2 == 1)
                                    {
                                        queso = new Queso(r.Next(W), r.Next(H), 1);

                                        for (int h = 0; h < quesos.Count; h++)
                                        {
                                            if (queso.posX == ((Queso)quesos[h]).posX && queso.posY == ((Queso)quesos[h]).posY)
                                                ((Queso)quesos[h]).AddQueso(1);
                                        }
                                        quesos.Add(queso);

                                    }
                    }//if (rat1.posX == rat2.posX && rat1.posY == rat2.posY)

                }//if2

                } //for2
            }  //if raton

        }//for
            
        }

        public void CheckMuerte()
        {
            for (int i = animales.Count-1; i >= 0; i--)
            {
                if (animales[i] is Raton)
                {
                    if (((Animal)animales[i]).pasosSinComida >= 20)
                        animales.RemoveAt(i);
                }
                else
                    if (((Animal)animales[i]).pasosSinComida >= 40)
                        animales.RemoveAt(i);
            }

            for(int i=quesos.Count-1;i>=0;i--)
                if(((Queso)quesos[i]).cantidad<=0)
                    quesos.RemoveAt(i);
            
        }


        public void CheckAgua()
        {
            for (int i = animales.Count-1; i >=0 ; i--)
            {
                if (animales[i] is Raton)
                {
                    if (((Animal)animales[i]).posX >= W || ((Animal)animales[i]).posY >= H
                        || ((Animal)animales[i]).posY < 0 || ((Animal)animales[i]).posX < 0)
                        animales.RemoveAt(i);
                }
                else
                {
                    if (((Animal)animales[i]).posX >= W)
                        ((Gato)animales[i]).posX = W - 1;
                    if (((Animal)animales[i]).posY >= H)
                        ((Gato)animales[i]).posY = H - 1;
                    if (((Animal)animales[i]).posX < 0)
                        ((Gato)animales[i]).posX = 0;
                    if (((Animal)animales[i]).posY < 0)
                        ((Gato)animales[i]).posY = 0;
                }
            }
        }
    }
}