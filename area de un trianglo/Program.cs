// See https://aka.ms/new-console-template for more information
Console.WriteLine("area de un triangulo");
Console.WriteLine();

double baseTriangulo = 5.0;
double alturaTriangulo = 7.0;
double area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);

Console.WriteLine("El área del triángulo es: " + area);
    

    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
{
    double area = (baseTriangulo * alturaTriangulo) / 2;
    return area;
}
