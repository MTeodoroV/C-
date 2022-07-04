using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using Caelum.Stella.CSharp.Vault;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Money money = valor;
		var brazil = new CultureInfo("pt-BR");
        Console.WriteLine(money.DisplayIn(brazil));  // R$ 10,50 BRL


        // Money euro = new Money(Currency.EUR, 1000);
        // Money dolar = new Money(Currency.USD,1000);
        // CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        // CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        // Money somaMoedasDiferentes = euro + dolar;
        // Console.WriteLine(somaMoedasDiferentes); // Retorna uma Unhandled exception.
    }
}