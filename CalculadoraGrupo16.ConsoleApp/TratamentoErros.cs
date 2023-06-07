using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGrupo16.ConsoleApp
{
    public static class TratamentoErros
    {
        public static List<string> erros = new();
        public static void VerificaDivisaoPor0(decimal numero1, decimal numero2)
        {
            if(numero1 > numero2)
            {
                erros.Add("Não é possível dividir por zero");
            }
        }

        public static void VerificaErrosNasContas(decimal numero1, decimal numero2)
        {
            VerificaDivisaoPor0(numero1, numero2);
            if(erros.Count > 0)
            {
                return;
            }
        }



    }
}
