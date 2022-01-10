using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    public abstract class Shape
    {
        //Add an atribute, type point, named position (always privated, unless it is need somewhere else]
        internal Point position;


        //Abstract need at least 1 Abstract Method, 1 invocação
        public Shape() 
        {
            position = new Point();
        }

        //Create a normal construct
        public Shape(Point position)
        { 
        this.position = position;
        }

        //Implement a Selector [get] and its Properties [set]
        public Point Position 
        {
        get { return position; }
        set { position = value; }
        }

        //Métodos abstractos só providenciam a assinatura do método 
        public abstract double Area();
        public abstract double Perimetro();
    }
}
