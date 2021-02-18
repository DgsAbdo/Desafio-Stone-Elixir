using System;
using System.Collections.Generic;

namespace DesafioElixirStone
{
    internal class Desafio
    {
        internal static Dictionary<string, int> Calcula(List<Item> itens, List<string> emails)
        {
            var totalValue = GetTotalValue(itens);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            SetValues(dic, totalValue, emails);
            return dic;
        }

        private static void SetValues(Dictionary<string, int> values, int totalValue, List<string> emails)
        {
            int resto = 0,index = 0;

            if (totalValue % emails.Count != 0)
                resto = totalValue % emails.Count;

            var valueDiv = totalValue / emails.Count;

            foreach (var i in emails)
            {
                if (++index <= emails.Count - resto)
                    values.Add(i, valueDiv);
                else
                    values.Add(i, valueDiv + 1);
            }
        }

        private static int GetTotalValue(List<Item> itens)
        {
            int total = 0, soma;

            foreach (var i in itens)
            {
                soma = 0;
                soma = i.Qtde * i.Value;
                total += soma;
            }

            return total;
        }

    }
}