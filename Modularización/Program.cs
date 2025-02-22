using System;
int opcion;

//programa de la calculadora
void suma(int n1,int n2)
{ 
   int suma = n1 + n2;
    Console.WriteLine($"La suma de los números es: {suma}");
}
void resta(int n1, int n2)
{
    int res = n1 - n2;
    Console.WriteLine($"La resta de los números es: {res}");
}
void multiplicacion(int n1, int n2)
{
    int mul = n1 * n2;
    Console.WriteLine($"La multiplicacion de los números es: {mul}");

}
void division(int n1, int n2)
{
    int div = n1 / n2;
    Console.WriteLine($"La divison de los números es: {div}");

}

void calculadora()
    
{
    int n1, n2, opcion;
    Console.WriteLine("Ingrese el primer numero");
   while(!int.TryParse(Console.ReadLine(),out n1))
    {
        Console.WriteLine("ERROR, debes de ingresar un NUMERO");
    }
    Console.WriteLine("Ingrese el segundo numero");
    while (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("ERROR, debes de ingresar un NUMERO");
    }
    Console.WriteLine("#####Calculadora#####\n1.Suma\n2.Resta\n3.Multipliacion\n4.Divison");
    Console.Write("Elige una opción: ");
    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("ERROR, debes de ingresar un NUMERO");
    }
    switch (opcion)
    {
        case 1:
            suma(n1,n2);
            break;
        case 2:
            resta(n1, n2);
            break;
        case 3:
            multiplicacion(n1, n2);
            break;
        case 4:
            division(n1, n2);
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    

}
//programa de validacion de contraseña
void validacion()
{
    Console.WriteLine("Inicio de sesión");
    Console.WriteLine("Ingrese el usuario");
    string usuario = Console.ReadLine();
    string contra;

    do
    {
        Console.WriteLine("Ingrese la contraseña:");
        contra = Console.ReadLine();

        if (contra != "1234")
        {
            Console.WriteLine("No es la contraseña");
        }

    } while (contra != "1234");

    Console.WriteLine($"Bienvenido {usuario}");
}

//programa de numeros primos
bool primo (int n)
{
    int a = 0;
    for (int i = 1; i < (n + 1); i++)
    {
        if (n % i == 0)
        {
            a++;
        }
    }
    if (a != 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}
void numerosprimos()
{
    Console.WriteLine("Ingrese un número entero:");
    int numero = int.Parse(Console.ReadLine());
    if (primo(numero))
    {
        Console.WriteLine("El número es primo");
    }
    else
    {
        Console.WriteLine("El número no es primo");
    }
}
//programa de suma de numeros pares

void sumapares()
{

    int sumaPares = 0;
    int numero;

    Console.WriteLine("Ingresa números enteros (ingresa 0 para terminar):");

    while (true)
    {
        Console.Write("Ingresa un número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 0)
        {
            break;
        }

        if (numero % 2 == 0)
        {
            sumaPares += numero;
        }
    }

    Console.WriteLine($"La suma de los números pares ingresados es: {sumaPares}");
}

//programa de conversion de temperatura

void conversion()
{
    int opcion;
    do
    {
        Console.WriteLine("\n### Conversión de Temperatura ###");
        Console.WriteLine("1. Convertir Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir Fahrenheit a Celsius");
        Console.WriteLine("3. Salir");
        Console.Write("Seleccione una opción: ");

        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Error: Debes ingresar un número válido.");
            Console.Write("Seleccione una opción: ");
        }

        switch (opcion)
        {
            case 1:
                ConvertirCelsiusAFahrenheit();
                break;
            case 2:
                ConvertirFahrenheitACelsius();
                break;
            case 3:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    } while (opcion != 3);
}
 void ConvertirCelsiusAFahrenheit()
{
    double celsius;
    Console.Write("Ingrese la temperatura en Celsius: ");
    while (!double.TryParse(Console.ReadLine(), out celsius))
    {
        Console.WriteLine("Error: Debes ingresar un número válido.");
        Console.Write("Ingrese la temperatura en Celsius: ");
    }
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}°F");
}

 void ConvertirFahrenheitACelsius()
{
    double fahrenheit;
    Console.Write("Ingrese la temperatura en Fahrenheit: ");
    while (!double.TryParse(Console.ReadLine(), out fahrenheit))
    {
        Console.WriteLine("Error: Debes ingresar un número válido.");
        Console.Write("Ingrese la temperatura en Fahrenheit: ");
    }
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"La temperatura en Celsius es: {celsius}°C");
}

//programa de contador de vocales
void contadorvocales()
{
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        int cantidadVocales = ContarVocales(frase);

        Console.WriteLine($"La cantidad de vocales en la frase es: {cantidadVocales}");
    }

     int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";

        foreach (char letra in texto)
        {
            if (vocales.Contains(letra))
            {
                contador++;
            }
        }

        return contador;
    }
}

//programa de factorial

void calculoFactorial()
{
    {
        Console.Write("Ingrese un número entero positivo: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("ERROR: Debe ingresar un número entero positivo.");
            Console.Write("Inténtelo de nuevo: ");
        }

        long resultado = Factorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {resultado}");
    }

     long Factorial(int n)
    {
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

//programa de juego de adivinanza

void juegoAdivinanza()
{
    Random random = new Random();
    int numeroSecreto = random.Next(1, 101); // Número aleatorio entre 1 y 100
    int intento;

    Console.WriteLine("¡Bienvenido al juego de adivinanza!");
    Console.WriteLine("Adivina el número entre 1 y 100");

    do
    {
        Console.Write("Ingresa tu número: ");
        while (!int.TryParse(Console.ReadLine(), out intento))
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
            Console.Write("Intenta de nuevo: ");
        }

        if (intento < numeroSecreto)
        {
            Console.WriteLine("Demasiado bajo, intenta nuevamente.");
        }
        else if (intento > numeroSecreto)
        {
            Console.WriteLine("Demasiado alto, intenta nuevamente.");
        }
    } while (intento != numeroSecreto);

    Console.WriteLine($"¡Felicidades! Has adivinado el número {numeroSecreto}");
}

//programa de paso por referencia

void pasoPorReferencia()
{
    Console.Write("Ingresa el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

    Intercambiar(ref num1, ref num2);

    Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
}

 void Intercambiar(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//programa de tabla de multiplicar

void tablaMultiplicar()
{
    Console.Write("Ingresa un número para generar su tabla de multiplicar: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        int[] tabla = GenerarTablaMultiplicar(numero);
        MostrarTabla(tabla, numero);
    }
    else
    {
        Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
    }
}

 int[] GenerarTablaMultiplicar(int numero)
{
    int[] tabla = new int[10];
    for (int i = 0; i < 10; i++)
    {
        tabla[i] = numero * (i + 1);
    }
    return tabla;
}

 void MostrarTabla(int[] tabla, int numero)
{
    Console.WriteLine($"Tabla de multiplicar del {numero}:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
    }
}




do
{
    Console.WriteLine("Menu de programas\n1.Calculadora\n2.Validación de contraseña\n3.Números primos\n4.Suma de números pares\n5.Conversión de temperatura\n6.Contador de vocales\n7.Cálculo de factorial\n8.Juego de adivinanza\n9.Paso por referencia\n10.Tabla de multiplicar\n11.Salir");
    Console.Write("Elige el número del programa que desea ejecutar: ");

    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("ERROR, debes de ingresar un NÚMERO");
    }

    switch (opcion)
    {
        case 1:
            calculadora();
            break;
        case 2:
            validacion();
            break;
        case 3:
            numerosprimos();
            break;
        case 4:
            sumapares();
            break;
        case 5:
            conversion();
            break;
        case 6:
            contadorvocales();
            break;
        case 7:
            calculoFactorial();
            break;
        case 8:
            juegoAdivinanza();
            break;
        case 9:
            pasoPorReferencia();
            break;
        case 10:
            tablaMultiplicar();
            break;
        case 11:
            Console.WriteLine("Saliendo");
            break;
        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }

    

} while (opcion != 11); 

