// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ingresar y mostrar una cadena
Console.WriteLine("ingrese una cadena");
string cadena = Console.ReadLine();

Console.WriteLine("la cadena ingresada es: " +cadena);

// concatenar dos cadenas
Console.WriteLine("ingrese una nueva cadena");
string cadena2 = Console.ReadLine();

string Cconcatenada = cadena +" "+ cadena2;

Console.WriteLine("cadena concatenada: " +Cconcatenada);

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


//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla

int i=1;
foreach (char caracter in Cconcatenada)
{ 
    Console.WriteLine($"caracter {i}: {caracter}");
    i++;
}


//Buscar la ocurrencia de una palabra determinada en la cadena ingresada

Console.WriteLine("ingrese una palabra para buscar dentro de la cadena");
string palabra = Console.ReadLine();

int index = Cconcatenada.IndexOf(palabra);

if (index != -1)
{
    Console.WriteLine($"la palabra se encuentra en el indice {index}");
}else{
    Console.WriteLine($"la palabra no se encuentra en la cadena");
}

//Convierta la cadena a mayúsculas y luego a minúsculas.

string mayuscula = Cconcatenada.ToUpper();
string minuscula = Cconcatenada.ToLower();

Console.WriteLine($"Mayusculas: {mayuscula}");
Console.WriteLine($"Minusculas: {minuscula}");

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())

Console.WriteLine($"ingrese una cadena separada pos puntos");
string cadenaSeparada = Console.ReadLine();

string[] partes = cadenaSeparada.Split('.');

Console.WriteLine("Partes de la Cadena");
int j=1;
foreach (string parte in partes)
{
    Console.WriteLine($"{j}) {parte.Trim()}");
    j++;
}

//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
// simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
// por pantalla “582+2” y que le devuelva la suma de 582 con 2

Console.WriteLine("ingrese una ecuacion , ejemplo (524 + 35)");
string ecuacion = Console.ReadLine();
char operador ='+';

if (ecuacion.Contains("+")) operador = '+';
else if (ecuacion.Contains("-")) operador = '-';
else if (ecuacion.Contains("*")) operador = '*';
else if (ecuacion.Contains("/")) operador = '/';

string[] numeros = ecuacion.Split(operador);

int resultado=0;
int numA = int.Parse(numeros[0]);
int numB = int.Parse(numeros[1]);

switch (operador)
{
    case '+':resultado = numA + numB;
    break;

    case '-':resultado = numA - numB;
    break;

    case '*':resultado = numA * numB;
    break;

    case '/':
        if (numB != 0)
        {
            resultado = numA / numB;
        }else
        {
            Console.WriteLine("operacion invalida");
        }
    break;

    default:
    break;
}

Console.WriteLine($"{resultado}");