using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESAR COORDENADAS");

            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("Ingresar coordenada x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar coordenada y1");
            int y1 = int.Parse(Console.ReadLine());
            rectangulo.p1 = new Punto(x1, y1);
            Console.WriteLine("Ingresar coordenada x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar coordenada y2");
            int y2 = int.Parse(Console.ReadLine());
            rectangulo.p2 = new Punto(x2, y2);
            Console.WriteLine("Ingresar coordenada x3");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar coordenada y3");
            int y3 = int.Parse(Console.ReadLine());
            rectangulo.p3 = new Punto(x3, y3);
            Console.WriteLine("Ingresar coordenada x4");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar coordenada y4");
            int y4 = int.Parse(Console.ReadLine());
            rectangulo.p4 = new Punto(x4, y4);

            Console.WriteLine("Area del rectangulo es " + rectangulo.CalcularArea());
            Console.WriteLine("Perimetro del rectangulo es " + rectangulo.CalcularPerimetro());

            Persona persona = new Persona();

            persona.Nombres = "Genaro";
            persona.Apellidos = "Valqui";

            string nombresCompletos;
            nombresCompletos = persona.DevolverNombresCompletos();


            Console.WriteLine(nombresCompletos);
            Console.Read();
        }
    }
}
