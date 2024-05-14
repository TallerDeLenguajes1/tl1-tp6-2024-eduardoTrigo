// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

Console.WriteLine("invertir valores de variables");

int c;
int d;
int aux;
c = 10;
d = 5;

if (c > 0 && d > 0)
{
    aux = c;
    c = d;
    d = aux;
}


Console.WriteLine("valor c:" + c);
Console.WriteLine("valor d:" + d);

Console.WriteLine("invertir numero");

int num;
int aux1;
int invertido = 0;
num = 156;


if (num > 0)
{
    while (num != 0)
    {
        aux1 = num % 10;
        num /= 10;
        invertido = (invertido * 10) + aux1;
    }
}

Console.WriteLine("invertido:"+invertido);