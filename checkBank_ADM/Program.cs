using System;
using checkBank_ADM.Funcionarios;
using checkBank_ADM.SistemaInterno;
using checkBank_ADM.Utilitario;

SistemaInterno gerenciador = new SistemaInterno();

// Designer mateus = new Designer("123.456.789-96");
// mateus.Nome = "Mateus";

// gerenciador.Registrar(mateus);

// System.Console.WriteLine("Total de bonificação do funcionario " + mateus.Nome + ": " + gerenciador.getBonificacao());

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();
    Diretor mateus = new Diretor("159.753.398-04");
    mateus.Nome = "Mateus";
    mateus.Senha = "123";

    sistemaInterno.Logar(mateus, "123");

}
