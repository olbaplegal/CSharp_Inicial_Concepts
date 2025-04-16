﻿using FundamentosLINQ;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("##LINQ - Filtrar dados ##\n");

//numeros = 1, 2, 4, 8, 16, 32, 64, 128, 512
var numeros = FonteDados.GetNumeros();

var resultado1 = numeros.Where(n => n < 10);

var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

//16, 128, 512
var listaNegra = FonteDados.GetListaNegra();

var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

var resultado4 = numeros.Where(n => n > 1)
                        .Where(n => n != 4)
                        .Where(n => n < 20);

Console.WriteLine(String.Join(" ", resultado4));//String.Join()

//objetos complexos

var alunos = FonteDados.GetAlunos();

var resultado5 = alunos.Where(a => a.Nome.StartsWith('A')
                                    && a.Idade < 18);

foreach (var aluno in resultado5)
{
    Console.WriteLine(aluno.Nome + " : " + aluno.Idade);
}

//sintaxe de consulta
var filtro = from a in alunos
             where a.Nome.StartsWith('A') && a.Idade < 18
             select a;

Console.ReadKey();

//predicate é um jeito de testar se um algo é falso ou verdadeiro em um objeto T