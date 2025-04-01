

//Você deve desenvolver uma aplicação simples de console em C# ou Python que execute as seguintes tarefas: Cadastro de Usuários: A aplicação deve permitir o cadastro de usuários com as informações: nome, e-mail e idade. Os dados devem ser armazenados em uma lista em memória. Listagem de Usuários: Implementar uma funcionalidade que liste todos os usuários cadastrados, exibindo suas informações no console. Busca de Usuário: A aplicação deve permitir a busca de um usuário pelo nome e exibir suas informações, se encontrado. Instruções: O código deve ser claro e bem comentado. Cole no campo de resposta abaixo o código-fonte e, também, coloque o link de algum tipo de drive contendo arquivo ZIP com os anexos utilizados.Esta pergunta é obrigatória*

using System;
using System.Text.RegularExpressions;

namespace ConsoleAutoMind;

class Program
{
    static void Main(string[] args)
    {
        // Condição para encerrar o While-loop'
        Boolean Done = false;

        // Dados do usuario
        String nome;
        String email;
        int idade;
        
        // Regex para validar formatação do email
        string validacao = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
        
        // Lista que armazena os usuarios na memoria
        List<User> users = new List<User>();
        
        // Limpar o terminal antes da aplicação começar
        Console.Clear();

        while (Done == false)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1. Cadastrar novo Usuario");
            Console.WriteLine("2. Listar Usuarios");
            Console.WriteLine("3. Procurar nome");
            Console.WriteLine("4. Encerrar sessão");
            int? selector = Convert.ToInt32(Console.ReadLine());
            switch (selector)
            {
                
                // Logica de Cadastro de usuario
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o nome do Usuario: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o email do Usuario: ");
                    email = Console.ReadLine();
                    if (Regex.IsMatch(email, validacao))// Validação de email
                    {
                        Console.WriteLine("Digite o idade do Usuario: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        User usuario = new User(nome, email, idade);
                        users.Add(usuario); //Adicionar o Usuario a lista.
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Email invalido");
                        break;
                    }
                    
                    
                // Logica de listar todos os usuarios da lista    
                case 2:
                    Console.Clear();
                    if (users.Count > 0)
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            Console.WriteLine("Nome: " + users[i].Nome);
                            Console.WriteLine("Email: " + users[i].Email);
                            Console.WriteLine("Idade: " + users[i].Idade);
                            Console.WriteLine();
                        }

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("A lista esta vazia");
                    }
                    break;
                
                //Logica de procurar nome de usuario.
                case 3:
                    Console.Clear();
                    if (users.Count > 0)
                    {
                        Console.WriteLine("Digite o nome do Usuario: ");
                        String query = Console.ReadLine();
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Nome.Equals(query))
                            {
                                Console.WriteLine(users[i].Nome + " - " + users[i].Email + " - " + users[i].Idade);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não ha usuarios cadastrados ");
                    }
                    
                    break;
                
                //Encerrar a sessão
                case 4:
                    Console.Clear();
                    Done = true;
                    break;
                
                //Lidar com erros de usuario
                default:
                    Console.WriteLine("Algum erro ocorreu! Tente novamente!");
                    return;
            }

            selector = null;//Limpar o valor do seletor para reiniciar o loop
        }
    }
}