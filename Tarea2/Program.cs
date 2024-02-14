int entero;
decimal numero1;

try
{
    Console.WriteLine("Holi, por favor ingresa un numero entero");
    entero = Convert.ToInt16(Console.ReadLine());
    numero1 = (decimal)entero;
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
