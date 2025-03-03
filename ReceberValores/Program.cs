using System;
using System.Collections.Generic;

class Program
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }

    static void Main()
    {
        int opcao;
        List<Pessoa> cadastro = new List<Pessoa>();

        do
        {
            Console.Clear();
            Console.WriteLine("--- Sistema de Cadastro ---");
            Console.WriteLine("1 - Cadastrar Cidadão");
            Console.WriteLine("2 - Visualizar Lista de Cadastro");
            Console.WriteLine("3 - Sair do Sistema");
            Console.Write("Escolha a Opção Desejada: ");

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Opção inválida. Digite um número: ");
            }

            switch (opcao)
            {
                case 1:
                    CadastrarPessoa(cadastro);
                    break;
                case 2:
                    ListarCadastros(cadastro);
                    break;
                case 3:
                    Console.WriteLine("Saindo do Sistema.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente Novamente.");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opcao != 3);   
    }

    static void CadastrarPessoa(List<Pessoa> cadastros)
    {
        Console.Clear();
        Console.WriteLine("--- Cadastrar Pessoa ---");

        Pessoa novaPessoa = new Pessoa();

        Console.Write("Digite o nome: ");
        novaPessoa.Nome = Console.ReadLine().Trim();

        int idade;
        Console.Write("Digite a idade: ");
        while(!int.TryParse(Console.ReadLine(), out idade) || idade < 0) 
        {
            Console.WriteLine("Idade inválida. Digite novamente: ");
        }
        novaPessoa.Idade = idade;

        Console.Write("Digite o Email: ");
        novaPessoa.Email = Console.ReadLine().Trim();

        cadastros.Add(novaPessoa);
        Console.WriteLine("\nCadastro realizado com sucesso!");
    }

    static void ListarCadastros(List<Pessoa> cadastro)
    {
        Console.Clear();
        Console.WriteLine("--- Lista de Cadastros ---");

        if(cadastro.Count == 0)
        {
            Console.WriteLine("Nenhuma pessoa cadastrada no sistema.");
            return;
        }
        for (int i = 0; i < cadastro.Count; i++)
        {
            Console.WriteLine($"\nCadastro {i + 1}");
            Console.WriteLine($"Nome: {cadastro[i].Nome}");
            Console.WriteLine($"Idade: {cadastro[i].Idade}");
            Console.WriteLine($"Email: {cadastro[i].Email}");
        }
    }
}