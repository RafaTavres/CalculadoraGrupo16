using static CalculadoraGrupo16.ConsoleApp.Adicao;
using static CalculadoraGrupo16.ConsoleApp.Multiplicacao;
using static CalculadoraGrupo16.ConsoleApp.Subtracao;

namespace CalculadoraGrupo16.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 2;

            double resultadoSoma = OperacaoSoma.Calcular(a, b);
            Console.WriteLine($"A soma de {a} e {b} é: {resultadoSoma}");

            double resultadoSubtracao = OperacaoSubtrair.Calcular(a, b);
            Console.WriteLine($"A subtração de {a} por {b} é: {resultadoSubtracao}");

            double resultadoMultiplicacao = OperacaoMultiplicar.Calcular(a, b);
            Console.WriteLine($"A multiplicação de {a} por {b} é: {resultadoMultiplicacao}");

            Console.ReadLine();
        }                                   
    }
 }
    
