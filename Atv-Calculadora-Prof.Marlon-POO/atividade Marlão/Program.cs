using System.Collections.Generic;
using System;

namespace atividade_Marlão
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            System.Console.Write("\n\n Quatos numeros deseja trabalhar? Digite aqui: ");
            c.Numero = (Convert.ToInt32(System.Console.ReadLine()));

            for (int i = 0; i < c.Numero; i++)
            {
                Console.Write(" Digite um numero aqui para fazer a medida aritmetica: ");
                c.addNumero(Convert.ToDouble(System.Console.ReadLine()));
            }
            Console.Write("\n Resultado = " + c.Somar() / c.Numero);
            Console.Write("\n");

            System.Console.Write("\n\n Daqui para baixo é a ATIVIDADE 1 \n");

            c.addNumero(10.5);
            c.addNumero(2.5);

            System.Console.WriteLine(c.Somar());

            c.addNumero(10.5);
            c.addNumero(4.5);
            System.Console.WriteLine(c.Somar());

            c.addNumero(10);
            c.addNumero(5);
            c.addNumero(2);
            System.Console.WriteLine(c.subtrair());

            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.multiplicar());

            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.dividir());
        }
    }
}
