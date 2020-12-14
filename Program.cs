using System;
using Static_POO.classes;

namespace Static_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----BEM VINDO A CASA DE CÂMBIO-----");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SELECIONE A OPERAÇÃO DE CÂMBIO DESEJADA:");
            Console.WriteLine("[1] - REAL PARA DÓLAR AMERICANO");
            Console.WriteLine("[2] - DÓLAR AMERICANO PARA REAL");
            Console.WriteLine("[3] - REAL PARA EURO");
            Console.WriteLine("[4] - EURO PARA REAL");
            Console.WriteLine("[5] - REAL PARA LIBRA ESTERLINA");
            Console.WriteLine("[6] - LIBRA ESTERLINA PARA REAL");
            Console.WriteLine("[0] - SAIR");
            int opcao = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            do
            {
                
                switch (opcao)
                {
                    case 1:
                        Console.Write("INFORME O VALOR EM REAIS: R$ ");
                        float valorRS = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM DÓLARES É DE: U$ {ConversorMoedas.RealDolar(valorRS)}");
                    return;

                    case 2:
                        Console.Write("INFORME O VALOR EM DÓLARES: U$ ");
                        float valorUS = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM REAIS É DE: R$ {ConversorMoedas.DolarReal(valorUS)}");
                    return;

                    case 3:
                        Console.Write("INFORME O VALOR EM REAIS: R$ ");
                        valorRS = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM EUROS É DE: EU {ConversorMoedas.RealEuro(valorRS)}");
                    return;

                    case 4:
                        Console.Write("INFORME O VALOR EM EUROS: EU ");
                        float valorEU = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM REAIS É DE: R$ {ConversorMoedas.EuroReal(valorEU)}");
                    return;

                    case 5:
                        Console.Write("INFORME O VALOR EM REAIS: R$ ");
                        valorRS = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM LIBRAS ESTERLINAS É DE: L$ {ConversorMoedas.RealLibras(valorRS)}");
                    return;

                    case 6:
                        Console.Write("INFORME O VALOR EM LIBRAS ESTERLINAS: L$ ");
                        float valorLI = float.Parse(Console.ReadLine());
                        Console.WriteLine($"SEU CÂMBIO EM REAIS É DE: R$ {ConversorMoedas.LibrasReal(valorLI)}");
                    return;

                    case 0:
                        Console.WriteLine("SAINDO....");
                    break;


                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
                }
                
                
            } while (opcao != 0);

            Console.ResetColor();
        }
    }
}
