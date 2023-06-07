// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int LadoA, LadoB, resultado;

Console.WriteLine("Calcula el area de un Rectangulo");
Console.WriteLine("Ingrese el Lado A");
LadoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el Lado B");
LadoB = Convert.ToInt32(Console.ReadLine());    

resultado = LadoA * LadoB;

Console.WriteLine("Area del Rectangulo: " +resultado);