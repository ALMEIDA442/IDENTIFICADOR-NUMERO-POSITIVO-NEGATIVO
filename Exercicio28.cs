using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 28: Classificação de Número Positivo ou Negativo

            // Descrição:
            // Este exercício consiste em desenvolver um programa que leia um valor numérico inteiro
            // e o classifique como positivo, negativo ou neutro (zero).

            // Passo a Passo:

            // 1. Entrada de Dados:
            //    - Solicite ao usuário que insira um valor numérico inteiro.
            Console.WriteLine("Insira um valor numérico inteiro: ");
            //    - Aguarde a entrada do usuário.
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());


            // 2. Processamento:
            //    - Verifique se o número é positivo, negativo ou neutro (zero).
            bool negativo = false;
            bool positivo = false;
            bool neutro = false;

                if (numero == 0)
            {
                neutro = true;
            }else if (numero > 0)
            {
                positivo = true;
            }else if (numero < 0)
            { negativo = true; }
            

            
            // 3. Saída de Dados:
            //    - Apresente a classificação do número como positivo, negativo ou neutro (zero).
            if (negativo) {
                Console.WriteLine("O numero é negativo");
            }
            if (positivo)
            {
                Console.WriteLine("O numero é positivo");
            }
            if (neutro)
            {
                Console.WriteLine("O numero é neutro");
            }
            // Exemplos:

            // - Exemplo 1:
            //   - Entrada: -5
            //   - Saída: Negativo

            // - Exemplo 2:
            //   - Entrada: 10
            //   - Saída: Positivo

            // - Exemplo 3:
            //   - Entrada: 0
            //   - Saída: Neutro (Zero)

            // Exemplo em Pseudocódigo:
            // ENTRADA: numero
            // PROCESSAMENTO:
            //   - SE numero > 0
            //     - exibir "Positivo"
            //   - SENÃO SE numero < 0
            //     - exibir "Negativo"
            //   - SENÃO
            //     - exibir "Neutro (Zero)"
           
        }
    }
}
