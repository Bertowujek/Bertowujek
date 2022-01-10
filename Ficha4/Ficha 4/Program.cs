using Ficha4;

Point p1 = new Point();
Point p2 = new Point(0,10);
Point p3 = new Point(10, 10);

Console.WriteLine("x: " + p1.X);

p1.X = 10;

Console.WriteLine("x: " + p1.X);

double distance = p1.DistanceTo(p2);
Console.WriteLine("\nDistance: " + distance);

Triangle t1 = new Triangle();
Triangle t2 = new Triangle(p1, p2, p3);

double baseT = t2.Base();
double heightT = t2.Height();
double area = t2.Area();

Console.WriteLine("\nBase: " + baseT);
Console.WriteLine("Height: " + heightT);
Console.WriteLine("Area: " + area);


//Invocação de uma instância (sempre que faço new...)
Rectangle r1 =   new Rectangle(); 
Rectangle r2 = new Rectangle(new Point(0, 5), 5, 5);

double areaRect = r2.CalculateArea();
double perimRect = r2.CalculatePerimetro();

Console.WriteLine("\nO Retângulo. Perimetro r2:{0}, Area r2: {1}", perimRect, areaRect);
//Console.WriteLine("Area Rectangle: " + areaRect);


Point pointE = new Point(1,4);
Point pointF = new Point(6,6);

bool contains = r2.Contains(pointE);
bool contains2 = r2.Contains(pointF);

Console.WriteLine("\nr1 contains pointE: {0}, \nr2 cointains pointF : {1}", r1.Contains(pointE), r2.Contains(pointF));


/// ===== Inicio Ficha 5 =====

Circle c1 = new Circle();
Circle c2 = new Circle(new Point(5,5),5);

double areaCircle = c2.Area();
double perimCircle = c2.Perimetro();
    //Circle "C2" herdou a propriedade do Shape

Console.WriteLine("\nO Círculo. Perimetro c2:{0}, Area c2: {1}", perimCircle, areaCircle);
Console.WriteLine("Poição do círculo: " + c2.position);


