using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace trab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Perguntas:");
            Console.WriteLine("1 – Quantos artigos estão presentes no sistema?");
            Console.WriteLine("2 – Qual o artigo mais longo ?");
            Console.WriteLine("3 – Qual o texto do artigo com o título “X”?");
            Console.WriteLine("4 – Qual o contribuidor(autor) com mais participações em artigos ?");
            Console.WriteLine("5 – Qual o nome do contribuidor “Y”?");
            Console.WriteLine("6 – Quais os contribuidores do artigo com o título “X” ou id “Z”?");
            Console.WriteLine("7 – Qual a data da última revisão?");
            Console.WriteLine("8 – Quais são os N artigos com maior número de palavras?");
            Console.WriteLine("9 – Quais são os artigos cujos títulos começam por “XYZ”?");
            Console.WriteLine("10 – Quais os artigos que contém a palavra “P” no seu texto ? ");

            int pergunta = 0;
            try
            {
                pergunta = int.Parse(Console.ReadLine());

                if (pergunta > 10 || pergunta < 1)
                    throw new Exception("Insira um número entre 1 e 10");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Insira um número");
            }

            Console.Clear();
            switch (pergunta)
            {
                case 1:
                    Console.WriteLine("1 – Quantos artigos estão presentes no sistema ?");

                    break;
                case 2:
                    Console.WriteLine("2 – Qual o artigo mais longo ?");

                    break;
                case 3:
                    Console.WriteLine("3 – Qual o texto do artigo com o título ...?");
                    string titulo = Console.ReadLine();

                    break;
                case 4:
                    Console.WriteLine("4 – Qual o contribuidor(autor) com mais participações em artigos ?");

                    break;
                case 5:
                    Console.WriteLine("5 – Qual o nome do contribuidor ...?");
                    int id_contribuidor = int.Parse(Console.ReadLine());

                    break;
                case 6:
                    Console.WriteLine("6 – Quais os contribuidores do artigo com o título ... ou id ...?");
                    Console.WriteLine("Insira o título do artigo");
                    titulo = Console.ReadLine();
                    Console.WriteLine("Insira o id do artigo");
                    id_contribuidor = int.Parse(Console.ReadLine());


                    break;
                case 7:
                    Console.WriteLine("7 – Qual a data da última revisão?");

                    break;
                case 8:
                    Console.WriteLine("8 – Quais são os N artigos com maior número de palavras?");

                    break;
                case 9:
                    Console.WriteLine("9 – Quais são os artigos cujos títulos começam por ...?");
                    string inicio_titulo = Console.ReadLine();

                    break;
                case 10:
                    Console.WriteLine("10 – Quais os artigos que contém a palavra “P” no seu texto ? ");
                    
                    break;
                       
            }

        }
    }
}
