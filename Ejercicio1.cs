using System;

namespace Practica_5
{
    public class Ejericio1
    {
         public static int Tope(int n) 
    { 
        if (n == 1 || n == 0) 
            return 1; 
        if (n == 2) 
            return 2; 
  
        else
        
            return Tope(n - 3) + Tope(n - 2) + Tope(n - 1); 
    } 
       
    }
}