using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program 
{
    public class Program
    {
        static void Main(string[] args) 
        {
            int numero1 = 4;
            int numero2 = 10;
            int numero3 = 5;

            var soma = numero1 + numero2 + numero3;

            Console.WriteLine(soma);

            var quadrado1 = new Qadrado(); //cria um quadrado
            quadrado1.lado = 15; //medida do quadrado
            var quadrado2= quadrado1;
            quadrado2.lado=11;

            Console.WriteLine(quadrado1.lado); //quadrado 1 deve ter
            Console.WriteLine(quadrado2.lado); 

        }

        class Qadrado
        {
            public int lado;
        }
        
    }
}