using System;

namespace appejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero, segundonumero, tercernumero, cuartonumero, suma;

            Console.Write("ingrese el primer numero ");
            primernumero= int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo numero ");
            segundonumero = int.Parse(Console.ReadLine());
            Console.Write("ingrese el tercer mumero ");
            tercernumero = int.Parse(Console.ReadLine());
            Console.Write("ingrese el cuarto numero ");
            cuartonumero = int.Parse(Console.ReadLine());

            suma = primernumero + segundonumero + tercernumero + cuartonumero;

            Console.WriteLine($"la suma de numeros primos es {suma}");


            
        }
    }
}
