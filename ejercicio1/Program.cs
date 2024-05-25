// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Invertir Numero!");

int num;
string cadena = Console.ReadLine();

if (int.TryParse(cadena, out num))
{
    if (num > 0)
    {
        int aux;
        int invertido = 0;

        while (num != 0 )
        {
            aux = num % 10;
            num /= 10;
            invertido = (invertido * 10) + aux;  
        }

        Console.WriteLine("invertido: " +invertido);
    }
}else{
    Console.WriteLine("Entrada invalida");
}