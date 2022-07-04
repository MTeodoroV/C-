using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using Caelum.Stella.CSharp.Inwords;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        string extenso = new Numero(valor).Extenso();

        Console.WriteLine("Extenso: " + extenso); // Extenso: setenta e cinco

        string extensoBRL = new MoedaBRL(valor).Extenso();
        Console.WriteLine(extensoBRL); // Extenso: setenta e cinco setenta e cinco reais | Extenso: setenta e seis setenta e cinco reais e cinquenta centavos
    }
}