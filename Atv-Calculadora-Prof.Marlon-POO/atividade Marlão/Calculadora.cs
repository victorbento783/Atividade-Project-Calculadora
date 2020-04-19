using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_Marlão
{
    class Calculadora
    {
        public int Numero;

        private List<double> ListNumero = new List<double>();
        public void addNumero(double num)
        {
            this.ListNumero.Add(num);
        }
        public double Somar()
        {
            double resultado = 0;
            foreach (double numero in this.ListNumero)
            {
                resultado += numero;
            }
            this.ListNumero.Clear();
            return resultado;
        }
        public double subtrair()
        {
            double resultado = this.ListNumero[0];
            this.ListNumero.RemoveAt(0);
            foreach (double numero in this.ListNumero)
            {
                resultado -= numero;
            }
            this.ListNumero.Clear();
            return resultado;
        }
        public double multiplicar()
        {
            double resultado = this.ListNumero[0];
            this.ListNumero.RemoveAt(0);
            foreach (double numero in this.ListNumero)
            {
                resultado *= numero;
            }
            this.ListNumero.Clear();
            return resultado;
        }
        public double dividir()
        {
            double resultado = this.ListNumero[0];
            this.ListNumero.RemoveAt(0);
            foreach (double numero in this.ListNumero)
            {
                resultado /= numero;
            }
            this.ListNumero.Clear();
            return resultado;
        }

    }
}
