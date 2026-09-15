//--------------------------------------------------------------------      Encabezado del programa
using System.ComponentModel.Design;

Console.WriteLine("EJERCICIO_6");
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES CICLO WHILE"); //Nombre del ejercicio
Console.WriteLine();                                                        //Instruccion para dejar un espacio en blanco en la consola

//--------------------------------------------------------------------      Entradas 
string continuar = "si";
while (continuar == "si")
{
    Console.WriteLine("Ingrese el nombre del estudiante:");
    string nombre = Console.ReadLine() ?? "sin nombre"; // Variable para almacenar el nombre del estudiante

    double suma = 0; // Variable para almacenar la suma de las calificaciones
    for (int numero = 1; numero <= 5; numero++)
    {
        Console.Write($"Ingrese la calificación {numero}:");

        double calificacion = Convert.ToDouble(Console.ReadLine());

        suma = suma + calificacion;
    }

    //--------------------------------------------------------------------      Operaciones
    double promedio = suma / 5.0;     // variable donde guardamos una operacion 

    //--------------------------------------------------------------------      Salidas 
    Console.WriteLine();
    Console.WriteLine($"El nombre del estudiante es: {nombre}"); // "$" se usa para unir dos variables
    Console.WriteLine($"El promedio de las cinco calificaciones es: {promedio:F2}");// "$" se usa para unir dos variables

    if (promedio >= 90)
    {
        Console.WriteLine("Felicidades Alumno Aprobado");
        Console.WriteLine("Excelente");
    }
    else if (promedio >= 80 && promedio < 90)
    {
        Console.WriteLine("Felicidades Alumno Aprobado");
        Console.WriteLine("Alumno Bueno");
    }
    else if (promedio >= 70 && promedio < 80)
    {
        Console.WriteLine("Felicidades Alumno Aprobado");
        Console.WriteLine("Alumno Regular");
    }
    else if (promedio >= 60 && promedio < 70)
    {
        Console.WriteLine("Alumno Reprobado, Sigue Intentandolo");
        Console.WriteLine("Alumno Requiere Apoyo");
    }
    else if (promedio >= 10 && promedio < 70)
    {
        Console.WriteLine("Alumno Reprobado, Sigue Intentandolo");
        Console.WriteLine("Alumno Deficiente");
    }
    else if (promedio >= 0)
    {
        Console.WriteLine("Alumno Reprobado, Sigue Intentandolo");
        Console.WriteLine("Baja Definitiva");
    }
    Console.WriteLine();
    Console.WriteLine("¿Desea registrar otro estudiante? (si/no)");
    continuar = (Console.ReadLine() ?? "no").Trim().ToLower();
}