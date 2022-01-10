using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    public class Point
    //Exercício 4 : Processo de implementação, com atributos e métodos
    {
        private double x;
        private double y;

        public Point() //Construtor por Omissão == significa que nao tem argumentos 
        {
            //starting attributes
            this.x = 0;
            this.y = 0;
        }

        public double DistanceTo(Point other) //Método
        {
            double dx = Math.Pow(other.x - this.x, 2);
            double dy = Math.Pow(other.y - this.x, 2);

            return Math.Sqrt(dx + dy);
        } 

        //Constructors
        public Point(double x, double y)
        {
            //Setting attributes
            this.x = x;
            this.y = y;
        }

        //Methods for setting Xand Y values
        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        //iii. Alteração de ambos os atributos (x e y)
        public double getXY(double x,double y)
        {
            return this.x;
        }
    }
}
