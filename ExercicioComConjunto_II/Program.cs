using System;
using System.Collections.Generic;
using ExercicioComConjunto_II.Entities;

namespace ExercicioComConjunto_II
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> courseA = new HashSet<Student>();
            HashSet<Student> courseB = new HashSet<Student>();
            HashSet<Student> courseC = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student cod = new Student(int.Parse(Console.ReadLine()));
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student cod = new Student(int.Parse(Console.ReadLine()));
                courseB.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student cod = new Student(int.Parse(Console.ReadLine()));
                courseC.Add(cod);
            }

            HashSet<Student> all = new HashSet<Student>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine();
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
/*
 * PROBLEMA EXEMPLO:
 - Em um portal de cursos online, cada usuário possui um código único, representado por
um número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
alunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
quantidade total e alunos dele, conforme exemplo.

EXEMPLO SAÍDA:
How many students for course A? 3
21
35
22
How many students for course B? 2
21
50
How many students for course C? 3
42
35
13
Total students: 6
 */