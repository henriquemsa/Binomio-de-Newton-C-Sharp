using System;

namespace Program
{
    class Program
    {
        // Método para calcular o fatorial de um dado número
        public static int Fatorial(int numero)
        {
            // Valor neutro da multiplicação para um acumulador
            int resultado = 1;

            // 0! = 1
            if (numero == 0)
            {
                resultado = 1;
                return resultado;
            }
            // Cálculo para valores diferentes de 0
            else
            {
                for (int i = numero; i >= 1; i--)
                {
                    resultado = resultado * i;
                }
            }

            // Retorna o resultado do fatorial
            return resultado;
        }

        // Método para calcular o coeficiente binomial
        public static double CoeficienteBinomial(int n, int p)
        {
            double resultado;

            // Cálculo do coeficiente binomial, onde:
            //               n!
            //          -------------
            //          p! * (n - p)!
            resultado = (Fatorial(n) / (Fatorial(p) * Fatorial(n - p)));

            // Retorna o resultado do coeficiente binomial
            return resultado;
        }

        // Método para calcular o Binômio de Newton
        public static double BinomioDeNewton(double a, double b, int n)
        {
            double resultado = 0;

            // Cálculo do Binômio de Newton, onde:
            for (int p = 0; p <= n; p++)
            {
                resultado = resultado + (CoeficienteBinomial(n, p) * (Math.Pow(a, (n - p)) * Math.Pow(b, p)));
            }

            // Retorna o resultado do Binômio de Newton
            return resultado;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            double a, b, resultado;
            int n;
            string opcao = "n";

            do
            {
                // Introdução do programa
                Console.Clear(); // Limpa tela
                Console.WriteLine(); // Pula linha
                Console.WriteLine("         PROGRAMA PARA CÁLCULO DE BINÔMIOS DE NEWTON");
                Console.WriteLine(); // Pula linha
                Console.WriteLine("                         (a + b) ^ n                ");
                Console.WriteLine(); // Pula linha
                Console.Write(" Entre com o valor de a: ");
                a = double.Parse(Console.ReadLine());

                Console.Clear(); // Limpa tela
                Console.WriteLine(); // Pula linha
                Console.WriteLine("         PROGRAMA PARA CÁLCULO DE BINÔMIOS DE NEWTON");
                Console.WriteLine(); // Pula linha
                Console.WriteLine("                        ({0} + b) ^ n                ", a);
                Console.WriteLine(); // Pula linha
                Console.Write(" Entre com o valor de b: ");
                b = double.Parse(Console.ReadLine());

                Console.Clear(); // Limpa tela
                Console.WriteLine(); // Pula linha
                Console.WriteLine("         PROGRAMA PARA CÁLCULO DE BINÔMIOS DE NEWTON");
                Console.WriteLine(); // Pula linha
                Console.WriteLine("                        ({0} + {1}) ^ n                ", a, b);
                Console.WriteLine(); // Pula linha
                Console.Write(" Entre com o valor de n: ");
                n = int.Parse(Console.ReadLine());

                Console.Clear(); // Limpa tela
                Console.WriteLine(); // Pula linha
                Console.WriteLine("         PROGRAMA PARA CÁLCULO DE BINÔMIOS DE NEWTON");
                Console.WriteLine(); // Pula linha
                Console.WriteLine("                      ({0} + {1}) ^ {2}                ", a, b, n);
                Console.WriteLine(); // Pula linha

                // Calculando resultado
                resultado = BinomioDeNewton(a, b, n);

                // Imprimindo resultado
                Console.WriteLine(" O resultado é: {0}", resultado);
                Console.WriteLine(); // Pula linha

                // Teste para repetir o laço
                Console.Write(" Deseja continuar a calcular binômios (S/N)? ");
                opcao = Console.ReadLine();
            } while (opcao != "N" && opcao != "n");

            // Finalizando o programa
            Console.WriteLine(); // Pula linha
            Console.WriteLine(" Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
