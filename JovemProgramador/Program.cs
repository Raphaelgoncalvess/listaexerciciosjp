using JovemProgramador;
using System.Globalization;
int escolhaMenuPrincipal;
int escolhaSegundoMenu = 0;
int escolhaTerceiroMenu = 0;
int escolhaQuartoMenu = 0;

Menus menus = new Menus();

do
{
    escolhaMenuPrincipal = menus.menuPrincipal();
    Console.Clear();
    switch (escolhaMenuPrincipal)
    {
        case 1:
            escolhaMenuPrincipal = 1;
            exercicio1();
            break;
        case 2:
            escolhaMenuPrincipal = 2;
            exercicio2();
            break;
        case 3:
            while (escolhaSegundoMenu != 4)
            {
                Console.Clear();
                escolhaMenuPrincipal = 3;
                escolhaSegundoMenu = menus.segundoMenu();
                if (escolhaSegundoMenu == 1)
                {
                    escolhaSegundoMenu = 1;
                    exercicio3();
                }
                if (escolhaSegundoMenu == 2)
                {
                    escolhaSegundoMenu = 2;
                    exercicio4();
                }
                if (escolhaSegundoMenu == 3)
                {
                    escolhaSegundoMenu = 3;
                    exercicio5();
                }
            }
            break;
        case 4:
            while (escolhaTerceiroMenu != 3)
            {
                Console.Clear();
                escolhaMenuPrincipal = 4;
                escolhaTerceiroMenu = menus.terceiroMenu();
                if (escolhaTerceiroMenu == 1)
                {
                    escolhaTerceiroMenu = 1;
                    exercicio6();
                }
                if (escolhaTerceiroMenu == 2)
                {
                    escolhaTerceiroMenu = 2;
                    exercicio7();
                }
            }
            break;
        case 5:
            while (escolhaQuartoMenu != 3)
            {
                Console.Clear();
                escolhaMenuPrincipal = 5;
                escolhaQuartoMenu = menus.quartoMenu();
                if (escolhaQuartoMenu == 1)
                {
                    escolhaQuartoMenu = 1;
                    exercicio8();
                }
                if (escolhaQuartoMenu == 2)
                {
                    escolhaQuartoMenu = 2;
                    exercicio9();
                }
            }
            break;
        case 6:
            escolhaMenuPrincipal = 6;
            exercicio10();
            break;
        case 7:
            escolhaMenuPrincipal = 7;
            exercicio11();
            break;
        case 8:
            escolhaMenuPrincipal = 8;
            break;
    }
} while (escolhaMenuPrincipal != 8);
static void exercicio1()
{
    Console.Clear();
    Console.WriteLine("Programa que retorna o nome completo, idade, altura e peso.");
    Console.Write("\nInforme seu nome completo: ");
    string nomeCompleto = Console.ReadLine();
    Console.Write("Informe sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    Console.Write("Informe sua altura usando virgula: ");
    double altura = double.Parse(Console.ReadLine());
    Console.Write("Informe seu peso usando virgula: ");
    double peso = double.Parse(Console.ReadLine());
    Console.WriteLine("\nSeu nome completo é " + nomeCompleto + ", você tem " + idade + " anos, " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura e pesa " + peso.ToString("F2", CultureInfo.InvariantCulture) + "Kg.\n");
    Console.WriteLine("Aperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio2()
{
    Console.Clear();
    Console.WriteLine("Programa que calcula a área de um quadrado.");
    Console.Write("\nInforme a medida de um dos lados do quadrado: ");
    double medida = double.Parse(Console.ReadLine());
    double area = Math.Pow(medida, 2);
    Console.WriteLine("A área do quadrado é: " + area);
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio3()
{
    Console.Clear();
    Console.WriteLine("Informe a hora atual (se for digitar os minutos, use 1 ponto(.) ao invés de 2 pontos(:):");
    double horaAtual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    if (horaAtual < 12)
    {
        Console.WriteLine("Bom dia!");
        Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
        Console.ReadLine();
    }
    if (horaAtual > 12 && horaAtual < 18)
    {
        Console.WriteLine("Boa tarde!");
        Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
        Console.ReadLine();
    }
    if (horaAtual > 18)
    {
        Console.WriteLine("Boa noite!");
        Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
        Console.ReadLine();
    }
}
static void exercicio4()
{
    Console.Clear();
    Console.WriteLine("Informe a nota da primeira avaliação: ");
    double nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da segunda avaliação: ");
    double nota2 = double.Parse(Console.ReadLine());
    double media = (nota1 + nota2) / 2;
    if (media < 6)
    {
        Console.WriteLine("NOTA FINAL: " + media + " - ALUNO REPROVADO.");
    }
    else
    {
        Console.WriteLine("NOTA FINAL: " + media + " - ALUNO APROVADO.");
    }
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio5()
{
    Console.Clear();
    Console.WriteLine("Informe o primeiro número: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o terceiro número: ");
    int numero3 = int.Parse(Console.ReadLine());
    if (numero1 > numero2 && numero1 > numero3)
    {
        Console.Clear();
        Console.WriteLine(numero1 + " é o maior número.");
    }
    else
    {
        if (numero2 > numero3)
        {
            Console.Clear();
            Console.WriteLine(numero2 + " é o maior número.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(numero3 + " é o maior número.");
        }
    }
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio6()
{
    Console.Clear();
    Console.Write("Crie uma senha de 4 números inteiros: ");
    int senhaUsuario = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.Write("Me informe sua senha: ");
    int senhaInformada = int.Parse(Console.ReadLine());
    Console.Clear();
    while (senhaInformada != senhaUsuario)
    {
        Console.Write("Senha Incorreta!");
        Console.Write("\nTente novamente: ");
        senhaInformada = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    Console.WriteLine("Senha Correta!");
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio7()
{
    Console.Clear();
    int numeroInserido, contador, verificarNumero;
    do
    {
        Console.WriteLine("Insira um número maior que 0: ");
        numeroInserido = int.Parse(Console.ReadLine());
        Console.Clear();
    } while (numeroInserido <= 0);
    for (contador = 1; contador <= numeroInserido; contador++)
    {
        verificarNumero = contador % 2;
        if (verificarNumero != 0)
        {
            Console.WriteLine(contador);
        }
    }
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio8()
{
    Console.Clear();
    string[] nomes; int qtdNomes; int contador;
    Console.WriteLine("Quantos nomes você quer digitar?");
    qtdNomes = int.Parse(Console.ReadLine());
    nomes = new string[qtdNomes];
    for (contador = 0; contador < qtdNomes; contador++)
    {
        Console.Clear();
        Console.WriteLine("Digite um nome: ");
        string nome = Console.ReadLine();
        nomes[contador] = nome;
        Console.Clear();
    }
    for (contador = 0; contador < qtdNomes; contador++)
    {
        Console.WriteLine(nomes[contador]);
    }
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio9()
{
    Console.Clear();
    int[] vetor = new int[5]; int contador; int soma = 0;
    for (contador = 0; contador < vetor.Length; contador++)
    {
        Console.Write($"Digite o {contador + 1}º número inteiro: ");
        vetor[contador] = int.Parse(Console.ReadLine());
        soma = soma + vetor[contador];
    }
    Console.Clear();
    Console.WriteLine("Resultado da soma de todos os números digitados: " + soma);
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio10()
{
    Console.Clear();
    Console.WriteLine("Programa que preencha uma matriz e a mostre com os números alinhados.");
    int[,] matriz = new int[4, 4];
    matriz[0, 0] = 1; matriz[0, 1] = 2; matriz[0, 2] = 3; matriz[0, 3] = 4; matriz[1, 0] = 10; matriz[1, 1] = 20; matriz[1, 2] = 30; matriz[1, 3] = 40; matriz[2, 0] = 12; matriz[2, 1] = 22; matriz[2, 2] = 32; matriz[2, 3] = 42; matriz[3, 0] = 15; matriz[3, 1] = 25; matriz[3, 2] = 35; matriz[3, 3] = 45;
    for (int linha = 0; linha < 4; linha++)
    {
        for (int coluna = 0; coluna < 4; coluna++)
        {
            if (linha == 0)
            {
                Console.Write($"{matriz[linha, coluna]}  ");
            }
            else
            {
                Console.Write($"{matriz[linha, coluna]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nAperte a tecla enter para voltar ao menu.");
    Console.ReadLine();
}
static void exercicio11()
{
    Console.Clear();
    Console.WriteLine("Programa que o usuário possa ver o saldo, depositar e sacar dinheiro.");
    double valorDeposito, valorSaque; int opcoes = 0; double saldo = 0; double resultado = 0;
    static int menu()
    {
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Ver o saldo");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("3 - Sacar");
        Console.WriteLine("4 - Sair");
        int opcoes = int.Parse(Console.ReadLine());
        return opcoes;
    }
    while (opcoes != 4)
    {
        opcoes = menu();
        Console.Clear();
        switch (opcoes)
        {
            case 1:
                opcoes = 1;
                mostrarSaldo(saldo);
                break;
            case 2:
                opcoes = 2;
                saldo = deposito(saldo, resultado);
                break;
            case 3:
                opcoes = 3;
                saldo = saque(saldo, resultado);
                break;
            case 4:
                opcoes = 4;
                break;
        }
    }
    static void mostrarSaldo(double saldo)
    {
        Console.WriteLine("Seu saldo é: R$" + saldo);
        Console.WriteLine("Aperte a tecla enter para voltar ao menu de operações.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Operação concluida!");
    }
    static double deposito(double saldo, double valorDeposito)
    {
        Console.WriteLine("Qual o valor que você deseja depositar?");
        valorDeposito = double.Parse(Console.ReadLine());
        double resultado = saldo + valorDeposito;
        Console.Clear();
        Console.WriteLine("Operação concluida!");
        return resultado;
    }
    static double saque(double saldo, double valorSaque)
    {
        double resultado = 0;
        Console.WriteLine("Qual o valor que você deseja sacar?");
        valorSaque = double.Parse(Console.ReadLine());
        if (saldo >= valorSaque)
        {
            resultado = saldo - valorSaque;
            Console.Clear();
            Console.WriteLine("Operação concluida!");
        }
        else
        {
            Console.WriteLine("Você não tem saldo suficiente na conta. Deposite para ter saldo suficiente.");
            Console.WriteLine("Aperte a tecla enter para voltar ao menu de operações.");
            Console.ReadLine();
            Console.Clear();
            resultado = saldo;
        }
        return resultado;
        Console.WriteLine("Aperta a tecla enter para voltar ao menu.");
        Console.ReadLine();
    }
}