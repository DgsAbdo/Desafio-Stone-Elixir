using System;
using System.Collections.Generic;

namespace DesafioElixirStone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itens = new List<Item>(); 
            List<string> emails = new List<string>();

            try
            {
                //Preenchendo as listas.
                //Coloque a quantidade de itens e e-mails que gostaria gerar.
                Console.Write("Digite a quantidade de itens que irão ser gerados: ");
                int qtdeItens = int.Parse(Console.ReadLine());
                Console.Write("\nDigite a quantidade de e-mails que irão ser gerados: ");
                int qtdeEmails = int.Parse(Console.ReadLine());
                
                //Gerando as listas de forma aleatoria apenas para testar a solução.
                Item.GetRandomItens(itens, qtdeItens);
                GetRandomEmails(emails, qtdeEmails);

                Dictionary<string, int> resultado = Desafio.Calcula(itens, emails);
                StringFormat(resultado); // printa o resultado
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }

        private static void StringFormat(Dictionary<string, int> resultado)
        {
            foreach(KeyValuePair<string, int> i in resultado)
            {
                Console.WriteLine("\nEmail: {0}; valor: {1}", i.Key, i.Value) ;
            }
        }

        private static void GetRandomEmails(List<string> emails, int qtde)
        {
            var rand = new Random();

            for (int i = 0; i < qtde; i++)
            {
                emails.Add($"{rand.Next(10,10000000)}@gmail.com");
            }
        }
    }
}
