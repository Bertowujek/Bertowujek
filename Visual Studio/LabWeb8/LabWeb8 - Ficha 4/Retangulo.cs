using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    public class Rectangle
    {
        ///atributos
        private Point topLeftPoint; //declaração do ponto esquerdo
        private double height;
        private double width;

        //#region Public Properties
        public Point TopLeftPoint 
        { 
            get { return topLeftPoint; }
            set { topLeftPoint = value; }   
        }

        public double Height
        {
            get { return height; }
            set {height = value; }
        }

        //Construtor por omissão (sem argumentos)
        public Rectangle() 
        {
        this.topLeftPoint = new Point();
        this.height = 0;
        this.width = 0;
        }

        //Construtor com parâmetros(pontos, altura, comprimento)
        public Rectangle(Point topLeftPoint, double height, double width) //O método vai receber os atributos
        { 
        this.topLeftPoint = topLeftPoint;
        this.height = height;
        this.width = width;
        }


        //=== MÉTODOS ====
        public double CalculateArea()
        { return width * height; } //base * altura

        public double CalculatePerimetro()
        { return (2 * width) + (2 * height); } //2* base + 2*altura

        public bool Contains(Point point)
        {
            Point topRightPoint = new Point(topLeftPoint.X + width, topLeftPoint.Y);
            Point bottomRightPoint;
            Point bottomLeftPoint;
        }
    }
}
