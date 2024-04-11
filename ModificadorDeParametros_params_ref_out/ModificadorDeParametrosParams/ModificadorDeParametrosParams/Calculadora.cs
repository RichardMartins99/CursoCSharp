using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParametrosParams
{
    public class Calculadora
    {
        //O params serve para receber diversos valores sem precisar enviar um vetor de numeros. Pode ser passado apenas diversos ints.Como exemplo abaixo.
        // Soma(2, 4, 5, 3)
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }

        //O modificador ref faz que o parametro da função seja uma referencia para a variavel original
        public static void Triple(ref int numero)
        {
            numero = numero * 3;
        }

        //O modificador out faz com que seja armazenado o valor na variavel de saida.
        public static void TripleOut(int origem, out int saida)
        {
            saida = origem * 3;
        }
    }
}
