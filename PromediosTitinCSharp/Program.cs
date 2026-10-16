// Amauris Willmore
// C# Fundamentos - Ejercicio de Promedios
// Profesor: Manuel Titin
//----------

using System;

class Program
{
    static void Main()
    {
        double p1, p2, p3, p4, promParciales, examen, trabajoF, promFinal;

        p1 = ReadDouble("Ingrese la calificación de P1:");
        p2 = ReadDouble("Ingrese la calificación de P2:");
        p3 = ReadDouble("Ingrese la calificación de P3:");
        p4 = ReadDouble("Ingrese la calificación de P4:");

        promParciales = ((p1 + p2 + p3 + p4) / 4.0) * 0.55;

        examen = ReadDouble("Ingrese la calificación del Examen:");
        trabajoF = ReadDouble("Ingrese la calificación del Trabajo Final (TrabajoF):");

        promFinal = promParciales + (examen * 0.30) + (trabajoF * 0.15);

        string literal = GetLiteralGrade(promFinal);

        Console.WriteLine($"El Promedio Final es: {promFinal:F2}");
        Console.WriteLine($"La calificación literal es: {literal}");
    }

    static double ReadDouble(string prompt)
    {
        double value;
        Console.WriteLine(prompt);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Entrada no válida. Intente de nuevo:");
        }
        return value;
    }

    static string GetLiteralGrade(double grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
}