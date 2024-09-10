using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampCodingTheFutureXPInc_Full_Stack_Developer_DIO.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");            
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");            
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x*y}");            
        }
        public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} ÷ {y} = {x/y}");            
        }
    }
}