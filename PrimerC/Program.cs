// See https://aka.ms/new-console-template for more information
using PrimerC;

Console.WriteLine("Julio su primer C#");
Console.WriteLine("0000000000000000000");
Console.WriteLine("Imprimir la Fecha:....");

try
{

    Console.WriteLine(new Date(2022, 3, 14));
    Console.WriteLine(new Date(2018, 7, 22));
    Console.WriteLine(new Date(2017, 2, 314));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}