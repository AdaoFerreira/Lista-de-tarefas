using System;
using System.Collections.Generic;
using System.Threading;

class Lista
{
    List<string> Tarefas = new List<string>();
    public void Opcoes()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao aplicativo de lista de tarefas");
        Console.WriteLine("Selecione as opções abaixo");
        Console.WriteLine("1 - Adicionar uma tarefa");
        Console.WriteLine("2 - Para mostrar as tarefas");
        Console.WriteLine("3 - Para excluir tarefas que já foram feitas");
        Console.WriteLine("4 - Para sair");
        string selecionar = Console.ReadLine();
        switch (selecionar)
        {
            case "1": Adicionartarefa();
                break;
            case "2": Mostrartarefa();
                break;
            case "3": Removertarefa();
                break;
            case "4": Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;

        }
    }

    public void Adicionartarefa()
    {
        Console.Clear();
        Console.WriteLine("Adicione uma tarefa que deseja adicionar: ");
        string adicionar = Console.ReadLine();
        Tarefas.Add(adicionar);
        Console.Clear();
        Opcoes();

    }

    public void Removertarefa()
    {
        Console.Clear();
        Console.WriteLine("Selecione uma tarefa que deseja remover: ");
        string remover = Console.ReadLine();
        
        if(Tarefas.Count > 0)
        {
            Tarefas.Remove(remover);
            Thread.Sleep(3000);
        }
        else
        {
            Console.WriteLine("Não a tarefas aqui ou que selecionou selecionou como mencionado");
            Thread.Sleep(5000);
            Console.Clear();
        }
        
        Opcoes();
        
    }

    public void Mostrartarefa()
    {
        Console.Clear();
        Console.WriteLine("Aqui estão as tarefas para você fazer: ");
        if (Tarefas.Count < 1)
        {
            Console.WriteLine("Não a tarefas registradas");
            Thread.Sleep(3000);
        }
        else
        {
            foreach (string S in Tarefas)
            {
                Console.WriteLine("Tarefas registradas: ");
                Console.WriteLine(S);
                Thread.Sleep(3500);
               
            }
        }      
        Opcoes();
        
    }
}