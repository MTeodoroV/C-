using System;
using checkBank_ADM.Funcionarios;
using checkBank_ADM.Utils;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Funcionario funcionario1 = new Funcionario();
funcionario1.Nome = "Mateus";
funcionario1.Cpf = "123456789";
funcionario1.Salario = 2000;

Diretor diretor1 = new Diretor();
diretor1.Nome = "Mateus1";
diretor1.Cpf = "987654321";
diretor1.Salario = 5000;

Funcionario andre = new Diretor();
andre.Nome = "Andre";
andre.Cpf = "1234568179";
andre.Salario = 3000;

Console.WriteLine("Bonificação: " + funcionario1.getBonificacao());
Console.WriteLine("Bonificação: " + diretor1.getBonificacao());

gerenciador.Registrar(funcionario1);
gerenciador.Registrar(diretor1);

System.Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());