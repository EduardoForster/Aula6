using System;
using System.Collections.Generic;

class Heroi
{
    public string Nome, Poder;
    public int Pontuacao;
    public Heroi(string nome, string poder, int pontuacao) => (Nome, Poder, Pontuacao) = (nome, poder, pontuacao);
}

class Program
{
    static List<Heroi> herois = new(), equipe = new();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n1-Cadastrar Herói\n2-Selecionar Equipe\n3-Calcular Pontuação\n4-Exibir Equipe\n5-Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1 && herois.Count < 5)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Poder: ");
                string poder = Console.ReadLine();
                Console.Write("Pontuação: ");
                int pont = int.Parse(Console.ReadLine());
                herois.Add(new Heroi(nome, poder, pont));
            }
            else if (opcao == 2)
            {
                equipe.Clear();
                if (herois.Count == 0) { Console.WriteLine("Cadastre heróis primeiro."); continue; }

                for (int i = 0; i < herois.Count; i++)
                    Console.WriteLine($"{i + 1} - {herois[i].Nome}");

                while (equipe.Count < 3)
                {
                    Console.Write($"Escolha {equipe.Count + 1}º herói: ");
                    int esc = int.Parse(Console.ReadLine()) - 1;
                    if (esc >= 0 && esc < herois.Count && !equipe.Contains(herois[esc]))
                        equipe.Add(herois[esc]);
                    else Console.WriteLine("Inválido ou repetido.");
                }
            }
            else if (opcao == 3)
                Console.WriteLine("Pontuação total: " + (equipe.Count == 0 ? 0 : equipe.Sum(h => h.Pontuacao)) + " pontos");
            else if (opcao == 4)
            {
                if (equipe.Count == 0) { Console.WriteLine("Equipe vazia."); continue; }
                foreach (var h in equipe)
                    Console.WriteLine($"{h.Nome} | {h.Poder} | {h.Pontuacao} pts");
                Console.WriteLine("Total: " + equipe.Sum(h => h.Pontuacao) + " pontos");
            }
            else if (opcao != 5) Console.WriteLine("Opção inválida.");
        } while (opcao != 5);
    }
}