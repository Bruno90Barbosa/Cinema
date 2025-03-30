using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msgPrincipal = "Lista de Filmes Disponiveis Conforme a sua idade: ";

            Console.WriteLine("Cinema público".ToUpper());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingresso gerado".ToUpper());
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");

            if (idade >= 18)
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------");
                Livre();
                Apartir10Anos();
                Apartir12Anos();
                Apartir14Anos();
                Apartir16Anos();
                Apartir18Anos();
            }
            else if (idade >= 16 && idade <=17)
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------"); 
                Livre();
                Apartir10Anos();
                Apartir12Anos();
                Apartir14Anos();
                Apartir16Anos();
            }
            else if (idade >=14 && idade <=15)
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------");
                Livre();
                Apartir10Anos();
                Apartir12Anos();
                Apartir14Anos();
            }
            else if (idade >=12 && idade <=13)
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------");
                Livre();
                Apartir10Anos();
                Apartir12Anos();
            }
            else if (idade >= 10 && idade <= 11)
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------");
                Livre();
                Apartir10Anos();
            }
            else if (idade <= 9 )
            {
                Console.WriteLine(msgPrincipal);
                Console.WriteLine("--------------------------------------------------");
                Livre();
            }

        }

        static void Livre()
        {
            Console.WriteLine("Toy Story (1995)");
            Console.WriteLine("E.T. - O Extraterrestre (1982)");
            Console.WriteLine("A Noviça Rebelde (1965)");
            Console.WriteLine("O Mágico de Oz (1939)");
            Console.WriteLine("Viva - A Vida É Uma Festa (2017)");

        }

        static void Apartir10Anos()
        {
            Console.WriteLine("Harry Potter e a Pedra Filosofal (2001)");
            Console.WriteLine("De Volta para o Futuro (1985)");
            Console.WriteLine("Matilda (1996)");
            Console.WriteLine("Homem-Aranha no Aranhaverso (2018)");
            Console.WriteLine("Extraordinário (2017)");
        }

        static void Apartir12Anos()
        {
            Console.WriteLine("Jogos Vorazes (2012)");
            Console.WriteLine("Divergente (2014)");
            Console.WriteLine("Maze Runner: Correr ou Morrer (2014)");
            Console.WriteLine("A Chegada (2016)");
            Console.WriteLine("As Vantagens de Ser Invisível (2012)");
        }

        static void Apartir14Anos()
        {
            Console.WriteLine("A Culpa é das Estrelas (2014)");
            Console.WriteLine("Coringa (2019)");
            Console.WriteLine("Interestelar (2014)");
            Console.WriteLine("Clube da Luta (1999)");
            Console.WriteLine("Garota Exemplar (2014)");
        }

        static void Apartir16Anos()
        {
            Console.WriteLine("Parasita (2019)");
            Console.WriteLine("O Irlandês (2019)");
            Console.WriteLine("Blade Runner 2049 (2017)");
            Console.WriteLine("Manchester à Beira-Mar (2016)");
            Console.WriteLine("Animais Noturnos (2016)");
        }

        static void Apartir18Anos()
        {
            Console.WriteLine("Oldboy (2003)");
            Console.WriteLine("Irreversível (2002)");
            Console.WriteLine("Ninfomaníaca (2013)");
            Console.WriteLine("Laranja Mecânica (1971)");
            Console.WriteLine("Bastardos Inglórios (2009)");
        }

    }
}
