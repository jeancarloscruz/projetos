﻿using System;
using System.Globalization;

namespace ExercicioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            f1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario");
            Console.WriteLine("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            f2.Salario = int.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salario medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}