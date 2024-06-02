// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ingresar y mostrar una cadena
Console.WriteLine("ingrese una cadena");
string cadena = Console.ReadLine();

Console.WriteLine("la cadena ingresada es: " +cadena);

// concatenar dos cadenas
Console.WriteLine("ingrese una nueva cadena");
string cadena2 = Console.ReadLine();

string Cconcatenada = cadena +""+ cadena2;

Console.WriteLine("cadena concatenada: "+Cconcatenada);

//Extraer una subcadena de la cadena ingresada
Console.WriteLine("ingrese un indice inicial de la sub-cadena");
int indice = int.Parse(Console.ReadLine());
// Console.WriteLine("ingrese la longitud");
// int longitud = int.Parse(Console.ReadLine());
int longitud = Cconcatenada.Length - indice;    //a la longitud de la cadena le resto los indices indicados
string subCadena = Cconcatenada.Substring(indice, longitud);    //genero la subCadena
Console.WriteLine("subcadena: "+subCadena);

//calculadora
Console.WriteLine("ingrese el numero A");
string cadenaA =Console.ReadLine();
float numA ;
Console.WriteLine("ingrese la operacion");
string operacion = Console.ReadLine();
Console.WriteLine("ingrese el numero B");
string cadenaB = Console.ReadLine();
float numB ;
float resultado;

if (float.TryParse(cadenaA, out numA) && float.TryParse(cadenaB, out numB) && (operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/" ))
{
    switch (operacion)
    {
        case "+": 
        resultado = numA + numB;
        Console.WriteLine($"La suma entre {numA} y {numB}: " +resultado);
        break;
        case "-": 
        resultado = numA - numB;
        Console.WriteLine($"La Resta entre {numA} y {numB}: " +resultado);
        break;
        case "*": 
        resultado = numA * numB;
        Console.WriteLine($"El producto entre {numA} y {numB}: " +resultado);
        break;
        case "/": 
        if (numB != 0)
        {

            resultado = numA/numB;
            Console.WriteLine($"La division de {numA} en {numB}: " +resultado);
        }
        break;
        default:
            Console.WriteLine("operacion incorrecta");
        break;
    }
}else{
            Console.WriteLine("Entrada inválida. Por favor, ingrese números válidos y una operación válida.");
}
// la funcion Tostring() sirve para convertir float o int en cadena de caracteres




