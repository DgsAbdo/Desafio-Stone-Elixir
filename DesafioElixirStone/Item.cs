using System;
using System.Collections.Generic;

namespace DesafioElixirStone
{
    internal class Item
    {
        public string ItemCode { get; set; }
        public int Qtde { get; set; }
        public int Value { get; set; }

        public static void GetRandomItens(List<Item> itens, int qtde)
        {
            var rand = new Random();

            for (int i = 0; i < qtde; i++)
            {
                itens.Add(new Item() { ItemCode = $"{i}", Qtde = rand.Next(1, 100), Value = rand.Next(100, 100000) });
            }
         
        }
    }
}