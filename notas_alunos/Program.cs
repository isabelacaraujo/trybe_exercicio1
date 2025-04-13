using System;
using System.Collections.Generic;  

class Program
{
    static void Main()
    {
        Dictionary<string, double> alunos = new Dictionary<string, double>()
        { {"Isabela", 10},
            {"Cyntia", 9.9},
            {"Daniel", 9.5},
            {"Thiago", 6.5},
            {"Rafael", 6},
            {"Alexandra", 7.8},
            {"Felipe", 4.5},
            {"Julia", 8.1},
            {"Fernanda", 6.8},
            {"Gabriel", 7.2},
            {"Lucas", 3.0},
            {"Laura", 9.8}
        };

        Console.WriteLine("Lista de alunos e notas:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"{aluno.Key}: {aluno.Value}");
        }
    }
}