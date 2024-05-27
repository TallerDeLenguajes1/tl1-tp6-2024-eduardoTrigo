// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Elija una opcion: ");
Console.WriteLine("1- Sumar.");
Console.WriteLine("2- Restar.");
Console.WriteLine("3- multiplicar.");
Console.WriteLine("4- Dividir.");
string cadena1 = Console.ReadLine() ?? "0"; // Manejar posibles valores nulos;
int opcion;

int.TryParse(cadena1, out opcion);

Console.WriteLine("usteda a elegido la opcion: " +opcion);
int a , b;
int resultado=0;
Console.WriteLine("ingrese el primer numero");
string numA = Console.ReadLine() ?? "0"; // Manejar posibles valores nulos;
Console.WriteLine("ingrese el segundo numero");
string numB = Console.ReadLine() ?? "0"; // Manejar posibles valores nulos;

int.TryParse(numA, out a);
int.TryParse(numB, out b);

switch (opcion)
{
    case 1: 
        resultado = a + b;
        Console.WriteLine("resultado de la operacion:" + resultado);
        break;
    case 2: 
        resultado = a - b;
        Console.WriteLine("resultado de la operacion:" + resultado);
        break;
    case 3: 
        resultado = a * b;
        Console.WriteLine("resultado de la operacion:" + resultado);
        break;
    case 4:
            double resultadoDivision;  //variable con punto flotante para la division
        if (b != 0)
        {
            resultadoDivision = (double)a / b;
            Console.WriteLine("resultado de la operacion:" + resultadoDivision);
        }else{
            Console.WriteLine("operacion invalida");
        }
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}
