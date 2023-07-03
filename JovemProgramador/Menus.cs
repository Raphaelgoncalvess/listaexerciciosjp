using System;

namespace JovemProgramador
{
    class Menus
    {
        public int menuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Olá! Bem vindo aos exercícios feitos através do curso Jovem Programador.");
            Console.WriteLine("\n1 - CONCATENAÇÃO");
            Console.WriteLine("2 - EXPRESSÕES ARITMÉTICAS");
            Console.WriteLine("3 - ESTRUTURA CONDICIONAL");
            Console.WriteLine("4 - ESTRUTURA REPETITIVA");
            Console.WriteLine("5 - VETORES");
            Console.WriteLine("6 - MATRIZES");
            Console.WriteLine("7 - ESTRUTURA SWITCH-CASE");
            Console.WriteLine("8 - ENCERRAR O PROGRAMA.");
            Console.WriteLine("\nDigite o número do programa que quer executar ou 8 para encerrar o programa:");

            int escolhaMenuPrincipal = int.Parse(Console.ReadLine());

            return escolhaMenuPrincipal;
        }
        public int segundoMenu()
        {
            Console.WriteLine("1 - Programa que retorna uma mensagem de acordo com o horário informado.");
            Console.WriteLine("2 - Programa que retorna uma mensagem com a nota do aluno e sua situação..");
            Console.WriteLine("3 - Programa que lê três números inteiros e mostra na tela o maior deles.");
            Console.WriteLine("4 - Voltar ao menu principal.");

            Console.WriteLine("\nDigite o número do programa que quer executar ou 4 para voltar ao menu principal:");

            int escolhaSegundoMenu = int.Parse(Console.ReadLine());

            return escolhaSegundoMenu;
        }
        public int terceiroMenu()
        {
            Console.WriteLine("1 - Programa que recebe uma senha e verifique se está correta.");
            Console.WriteLine("2 - Programa que mostra na tela todos os números ímpares até o número que o usuário informou.");
            Console.WriteLine("3 - Voltar ao menu principal.");

            Console.WriteLine("\nDigite o número do programa que quer executar ou 3 para voltar ao menu principal:");

            int escolhaTerceiroMenu = int.Parse(Console.ReadLine());

            return escolhaTerceiroMenu;
        }
        public int quartoMenu()
        {
            Console.WriteLine("1 - Programa que armazena N nomes e mostra na tela na sequência que foram digitados.");
            Console.WriteLine("2 - Programa que armazena 5 valores inteiros, calcule e apresente a soma.");
            Console.WriteLine("3 - Voltar ao menu principal.");

            Console.WriteLine("\nDigite o número do programa que quer executar ou 3 para voltar ao menu principal:");

            int escolhaQuartoMenu = int.Parse(Console.ReadLine());

            return escolhaQuartoMenu;
        }
    }
}
