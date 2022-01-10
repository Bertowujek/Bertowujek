using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
/*Breve Explicação de uma INTERFACE:
As classes que extenderem esta área é que vão se preocupar em calcular a área
Uma interface. Pensem num contrato: Existe uma classe abstrata, e quem quiser herdar os atributos e netos, terão de implementar os métodos da área e do períetro
Na declaração da classe circle, fazemos Circle:Shape
*/

    public class Circle : Shape
    {
        private double radius;

        public Circle() 
            //Construtor por omissão
            //A regra é, o nome é igual a classe
        {
            this.position = new Point();
            this.radius = 0;
        }

        public Circle(Point point, double radius)
            //Construtor com parâmetros
        {
            this.position = point;
            this.radius = radius;
        }


        //Override = subscreve por cima da classe Shape
        public override double Area() 
        {
            return Math.PI * Math.Pow(radius, 2); //Area circulo = Pi * r^2
        }

        public override double Perimetro() 
        {
            return 2 * Math.PI * radius; //Perimetro circulo = 2* PI * r
        }

        public override string ToString()
        {
            return Position.ToString() + ", Radius: " + this.radius;

        }
    }
}
