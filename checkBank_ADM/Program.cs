using System;
using checkBank_ADM.Funcionarios;
using checkBank_ADM.Utils;

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer mateus = new Designer("123.456.789-96");
    mateus.Nome = "Mateus";

    gerenciador.Registrar(mateus);

    System.Console.WriteLine("Total de bonificação do funcionario " + mateus.Nome + ": " + gerenciador.getBonificacao());
}