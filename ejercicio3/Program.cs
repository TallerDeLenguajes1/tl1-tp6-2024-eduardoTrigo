// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un Numero");

double num;
string cadena = Console.ReadLine();

if (double.TryParse(cadena, out num ))
{
double valorAbsoluto;
double cuadrado;
double raizCuadrada;
double seno;
double coseno;

//Valor Absoluto
valorAbsoluto = Math.Abs(num);
Console.WriteLine($"el valor absoluto de {num} es {valorAbsoluto}");
//Cuadrado

cuadrado = Math.Pow(num,2);
Console.WriteLine($"el Cuadrdado de{num} es {cuadrado}");

// raiz cuadrada
if (num > 0)
{
    raizCuadrada = Math.Sqrt(num);
    Console.WriteLine($"la Raiz cuadrada de {num} es {raizCuadrada}");
}else
{
    Console.WriteLine("No se puede calcular la raiz de un numero menor a 0");
}
//seno 
seno = Math.Sin(num);
Console.WriteLine($"el seno de {num} es {seno}");
// coseno
coseno = Math.Cos(num);
Console.WriteLine($"el coseno de {num} es {coseno}");

// la parte entera de un tipo float
int parteEntera = (int)num;
Console.WriteLine($"Parte Entera: {parteEntera}");

}else{
    Console.WriteLine("Entrada invalida");
}


int numA, numB;
Console.WriteLine("Ingrese Numero A");
string cadena1 = Console.ReadLine();
Console.WriteLine("Ingrese Numero A");
string cadena2 = Console.ReadLine();

int.TryParse(cadena1, out numA);
int.TryParse(cadena2, out numB);

if (numA > numB)
{
    Console.WriteLine("El numero A es mayor al numero B");
}else{
    if (numB > numA)
    {
        Console.WriteLine("El numero B es mayor al numero A");
    }else{
        Console.WriteLine("los numeros son iguales");
    }
}
