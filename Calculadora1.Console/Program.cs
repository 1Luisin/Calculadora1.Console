using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtração, Multiplicação, Divisão, Potência, Raiz, Sair}

        static void Main(string[] args)
        {
          
            bool naosair = false;
            while (!naosair)        
            {

                    Console.WriteLine("Seja bem vindo ao calc. :3\n\nSelecione uma das opções");
                    Console.WriteLine(" 1 - Soma\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão\n 5 - Potência\n 6 - Raiz\n 7 - Sair");

                string opcaotxt = Console.ReadLine();
                Int32 opcaonumber = Int32.Parse(opcaotxt);
                Menu opcao = (Menu)opcaonumber;

                Console.WriteLine(opcao);
                Console.Clear();

                
               /* if(opcao == null) 
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Opção não indentificada, tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                */
                
                
                if (opcaonumber <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Opção não listada, tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opcaonumber > 7) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("Erro! Código(E348). \nDigite um número válido.\n"); // Código E348 se refere a um número não listado.
                    Console.ResetColor();
                }
                switch (opcao)
                {
                    case Menu.Sair:
                        naosair = true;
                        break;

                    case Menu.Soma:
                        soma();
                        break;

                    case Menu.Subtração:
                        subt();
                        break;

                    case Menu.Divisão:
                        div();
                        break;

                    case Menu.Multiplicação:
                        mult();
                        break;

                    case Menu.Potência:
                        pot();
                        break;

                    case Menu.Raiz:
                        raiz();
                        break;                    
                }
            }
        }
          static void soma() // Função Soma
        {
            Console.WriteLine("Soma entre números");
            Console.WriteLine("\nDigite o primeiro numero:");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");

            int numero2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int somadosnumeros = numero1 + numero2;
            Console.WriteLine($"O resultado da soma é {somadosnumeros}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();
        }
        static void subt() // Função subtração
        {
            Console.WriteLine("Subtração entre números");
            Console.WriteLine("\nDigite o primeiro número");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número");

            int numero2 = int.Parse(Console.ReadLine());

            int subtdosnumeros = numero1 - numero2;

            Console.Clear();

            Console.WriteLine($"O resultado da subtração é {subtdosnumeros}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();
        }
        static void mult() // Função multiplicação
        {
            Console.WriteLine("Multiplicação entre números");
            Console.WriteLine("\nDigite o primeiro numero:");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");

            int numero2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int multiplicaçãonumeros = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação é {multiplicaçãonumeros}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();
        }
        static void div() // Função divisão
        {
            Console.WriteLine("Divisão entre números");
            Console.WriteLine("\nDigite o primeiro numero:");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");

            int numero2 = int.Parse(Console.ReadLine());

            Console.Clear();

            float divisaonumeros = (float)numero1 / (float)numero2;
            Console.WriteLine($"O resultado da divisão é {divisaonumeros}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();
        }

        static void pot() // Função Potência

        {
            Console.WriteLine("Potência entre números");
            Console.WriteLine("\nDigite a base que você deseja potenciar:");

            int numBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente:");

            int numEx = int.Parse(Console.ReadLine());

            Console.Clear();

            int potêncianumeros = (int)Math.Pow(numBase, numEx); // Math.Pow é uma classe que fornece constantes e métodos estáticos
                                                                 // para trigonométricos, logarítmicos e outras funções matemáticas comuns.
            Console.WriteLine($"O resultado da potência é {potêncianumeros}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();

        }
        static void raiz()
        {
            Console.Clear();
            Console.WriteLine("Raiz do número");
            Console.WriteLine("\nDigite o número  que você deseja saber a raiz:");

            int numBase = int.Parse(Console.ReadLine());

            Console.Clear();

            decimal raiznumero = (decimal)Math.Sqrt(numBase); // Math.Sqrt é uma classe que fornece constantes e métodos estáticos
                                                                 // para trigonométricos, logarítmicos e outras funções matemáticas comuns.
            Console.WriteLine($"O resultado da raiz é {raiznumero}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio");

            Console.ReadLine();
            Console.Clear();

        }

    }

}