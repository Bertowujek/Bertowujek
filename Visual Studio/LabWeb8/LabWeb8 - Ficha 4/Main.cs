// See https://aka.ms/new-console-template for more information

//Vamos invocar
/* A classe só por si, é só uma descrição
 * Uma instância é como um Objeto desse tipo
 * É a instância que invoca o MÉTODO
 * NomeClasse nome da instância = new NomeClasse
 */

using Ficha4; //Vai buscar a ficha4

//Instância p1 != p2
Point p1 = new Point(1, 1);
Point p2 = new Point(4, 4);
Point p3 = new Point(6, 6);
   

Console.WriteLine(p1.getX());
Console.WriteLine(p2.getY());

//p1.setX(100);
//p2.setY(200);
//p1.setXY(9, 9);

Console.WriteLine(p1.DistanceTo(p2));


// TRIÂNGULOS

Triangle t1 = new Triangle();
Triangle t2 = new Triangle(p1, p2, p3);

Console.WriteLine(t1);
