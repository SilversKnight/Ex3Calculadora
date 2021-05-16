using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ex3Calculadora
{
    public class Program
    {
        delegate int Calculo(int a, int b);

        static Calculo soma = (a, b) => a + b;

        static Calculo sub = (a, b) => a - b;

        static Calculo mult = (a, b) => a * b;

        static Calculo div = (a, b) => a / b;

        public static int Main(string[] args)
        {
            Console.WriteLine("Insira dois números inteiros:");
            int a, b,opcao,resultado = 0;
            double n = 0;
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);

            Console.WriteLine("Digite o número da opção desejada:" +
                "\n1.Soma" +
                "\n2.Subtração" +
                "\n3.Multiplicação" +
                "\n4.Divisão" +
                "\n5.Média" +
                "\n6.Fibonnaci Recursivo" +
                "\n7.Fibonnaci Iterativo");

            opcao = int.Parse(args[2]);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", a, b, resultado = soma(a,b));
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", a, b, resultado = sub(a, b));
                    break;
                case 3:
                    Console.WriteLine("{0} x {1} = {2}", a, b, resultado = mult(a, b));
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", a, b, resultado = div(a, b));
                    break;
                case 5: 
                    resultado = calcularMedia();
                    Console.WriteLine("Média obtida:{0}",calcularMedia()); 
                    break;
                case 6:
                    Console.WriteLine("Insira um número para calcular seu Fibonnaci Recursivo:");
                    n = double.Parse(Console.ReadLine());
                    Stopwatch stopRec = new Stopwatch();
                    stopRec.Start();
                    resultado = (int)fibonacciRecursivo(n);
                    stopRec.Stop();
                    Console.WriteLine("Resultado:{0}\nTicks gastos Fibonnaci:{1}", resultado, stopRec.ElapsedTicks); 
                    break;
                case 7:
                    Console.WriteLine("Insira um número para calcular seu Fibonnaci Iterativo:");
                    n = double.Parse(Console.ReadLine());
                    Stopwatch stopIt = new Stopwatch();
                    stopIt.Start();
                    resultado = (int)fibonacciIterativo(n);
                    stopIt.Stop();
                    Console.WriteLine("Resultado:{0}\nTicks gastos Fibonnaci Iterativo:{1}", resultado, stopIt.ElapsedTicks);
                    break;
                default:
                    Console.WriteLine("Opção inválida.Tente novamente.");
                    break;
            }

            return resultado;
        }

        public static int calcularMedia()
        {
            List<int> numeros = new List<int>();

            bool adicionarNumero = true;

            int soma = 0;

            while (adicionarNumero)
            {
                Console.WriteLine("Insira um número inteiro");
                numeros.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Digite '1' para inserir mais um número. Digite qualquer outro número para prosseguir com o calculo.");

                if(int.Parse(Console.ReadLine()) == 1) { }
                else { adicionarNumero = false; }
            }

            foreach (int num in numeros)
            {
                soma += num;
            }

            int media = soma / numeros.Count;

            return media;
        }

        public static double fibonacciRecursivo(double n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {

                return fibonacciRecursivo(n - 1) + fibonacciRecursivo(n - 2);//recursão 
            }
        }
        public static double fibonacciIterativo(double n)
        {
            int f = 0;
            int ant = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    f = 1;
                    ant = 0;
                }
                else
                {
                    f += ant;
                    ant = f - ant;
                }
            }
            return f;

        }
    }
}
