using System;


namespace Practica_5
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            
            Console.Write("Introduzca el tope que desea alcanzar: ");
             int tope = int.Parse(Console.ReadLine()); 
             Console.WriteLine();
             int exe1 = Ejericio1.Tope(tope);
             Console.WriteLine($"La cantidad de combinaciones que el tope {tope} tiene son {exe1}");
             
        } 
    }
}