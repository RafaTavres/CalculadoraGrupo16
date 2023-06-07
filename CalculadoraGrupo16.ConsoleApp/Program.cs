namespace CalculadoraGrupo16.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            do
            {

                Console.Clear();

                Console.WriteLine("Bem-vindo a Calculadora cooperativa 2023");

                Console.WriteLine("Digite 1 para Adcionar");
                Console.WriteLine("Digite 2 para Subtair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                String operacao = Console.ReadLine();

                if (operacao == "s" || operacao == "S")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "s" && operacao != "S")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine();
                Console.WriteLine("Digite o primeiro numero: ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Digite o segundo numero: ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtrair = operacao == "2";
                bool ehMultiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";

                if (ehAdicao)
                {
                    
                }

                else if (ehSubtrair)
                {
                    
                }

                else if (ehMultiplicacao)
                {
                    
                }


                else if (ehDivisao)
                {
                    

                }
                


            } while (true);

        }
    }
}