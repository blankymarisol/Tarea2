int entero;
decimal numero1;

try
{
    Console.WriteLine("Holi, por favor ingresa un numero entero");
    entero = Convert.ToInt16(Console.ReadLine());
    numero1 = (decimal)entero;
    Console.WriteLine("El numero en decimal es: " + numero1);
}
catch (Exception ex)
{
    Console.WriteLine("Cuidado!, cometiste un error:" + ex.Message);
}

decimal dec1;
float numero2;

try
{
    Console.WriteLine("Por favor, ingresa un número decimal:");
    dec1 = Convert.ToDecimal(Console.ReadLine());
    numero2 = (float)dec1;
    Console.WriteLine("Número flotante convertido: " + numero2);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

float numero3;
int entero2;

try
{
    Console.WriteLine("Por favor ingresa un numero flotante");
    numero3 = Convert.ToInt32(Console.ReadLine());
    entero2 = (int)numero3;
    Console.WriteLine("El numero convertido a entero es: " + entero2);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

char caracter3;
int numero4;

try
{
    Console.WriteLine("Por favor, ingresa una letra:");
    caracter3 = Console.ReadKey().KeyChar; 
    numero4 = (int)caracter3;
    Console.WriteLine("El valor numérico de la letra ingresada es " + numero4);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}

int numero5;
char caracter4;

try
{
    Console.WriteLine("Por favor, ingresa un numero:");
    numero5 = int.Parse(Console.ReadLine());
    caracter4 = (char)numero5;
    Console.WriteLine("El numero ingresado equivale a la letra:" + caracter4);
}
catch (Exception ex)
{
    Console.WriteLine("¡Cuidado! Ocurrió un error: " + ex.Message);
}