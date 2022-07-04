using System;
using checkBank;

contaCorrente conta1 = new contaCorrente();
conta1.titular = "Mateus Teodoro";
conta1.conta = "1234-x";
conta1.agencia = 2808;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Agengia: " + conta1.agencia);
Console.WriteLine("Nome da agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: R$ " + conta1.saldo + " Reais");
Console.WriteLine("Vericador: " + conta1.verificador);

Console.ReadKey();