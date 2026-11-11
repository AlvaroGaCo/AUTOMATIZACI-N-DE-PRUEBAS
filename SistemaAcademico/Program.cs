using System;

class Program
{
    static void Main()
    {
        string nombre = "Ana";
        int nota = 16;

        Console.WriteLine("=====SISTEMA ACADEMICO=====");
        Console.WriteLine("Estudiante: " + nombre);
        Console.WriteLine("Nota: " + nota);

        if (nota >= 11)
        {
            Console.WriteLine("Estado: Aprobado");
        }
        else
        {
            Console.WriteLine("Estado: Desaprobado");
        }
    }
}