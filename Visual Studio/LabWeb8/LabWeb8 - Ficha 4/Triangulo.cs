using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    //3.a) Diagrama composto por três pontos       
    public class Triangle //Relação de composição
    {

        private Point a; //Get. Significa que conseguimos ler o valor, Set. alterar o valor)
        private Point b;
        private Point c;

        
        ///Construtores
        public Triangle()
        {
            a = new Point();
            b = new Point();
            c = new Point(); //A invocar os atributos do Tipo Point
        }

        public Triangle (Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Pontos declarados
        public Point A  
        {
            get { return a; } 
            set { a = value; } 
        }
        public Point B  
        {
            get { return b; }
            set { b = value; }
        }
        public Point C
        {
            get { return c; }
            set { c = value; }
        }

        public double Base()
        {
            return a.DistanceTo(b);
        }

        public double Height()
        {
            return a.DistanceTo(c);
        }

        public double CalculateArea()
        {
            return (Base()) * Height()/2;  //Calculo a distância de dois pontos numa linha só
        }
    }
}
