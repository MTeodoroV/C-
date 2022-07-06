using System;
using checkBank;
using checkBank.Titular;

contaCorrente conta1 = new contaCorrente();
conta1.conta = "1234-x";
conta1.agencia = 2808;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

contaCorrente conta2 = new contaCorrente();
conta2.conta = "1235-x";
conta2.agencia = 2808;
conta2.nome_agencia = "Agencia Central";
conta2.saldo = 50;

// Console.WriteLine("Titular: " + conta1.titular);
// Console.WriteLine("Conta: " + conta1.conta);
// Console.WriteLine("Agengia: " + conta1.agencia);
// Console.WriteLine("Nome da agencia: " + conta1.nome_agencia);
// Console.WriteLine("Saldo: R$ " + conta1.saldo + " Reais");
// Console.WriteLine("Vericador: " + conta1.verificador);

// Console.WriteLine("Saldo conta 1: " + conta1.saldo);
// Console.WriteLine("Saldo conta 2: " + conta2.saldo);
// bool tranferencia = conta1.Transferir(75, conta2);
// Console.WriteLine("Transferencia: " + tranferencia);
// Console.WriteLine("Saldo conta 1: " + conta1.saldo);
// Console.WriteLine("Saldo conta 2: " + conta2.saldo);

// Console.WriteLine("Saldo pré-saque: " + conta1.saldo);
// bool saque = conta1.Sacar(10);
// Console.WriteLine("Saue realizado? " + saque);
// Console.WriteLine("Saldo pos-saque: " + conta1.saldo);

// Console.WriteLine("Saldo pré-deposito: " + conta1.saldo);
// conta1.Depositar(50);
// Console.WriteLine("Saldo pos-deposito: " + conta1.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Mateus";
cliente.cpf = "56984984";

contaCorrente conta3 = new contaCorrente();
conta3.titular = cliente;
conta3.conta = "6194984-x";
conta3.agencia = 35;
conta3.nome_agencia = "Agencia Central";

Console.WriteLine(conta3.titular.nome);


Console.ReadKey();