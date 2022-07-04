using System;
using System.Diagnostics;
using Caelum.Stella.CSharp.Validation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o cpf (Sem ponto ou traço): ");
        string cpf = Console.ReadLine();
        ValidateCPF(cpf);

        Console.WriteLine("Digite o cnpj (Sem ponto ou traço): ");
        string cnpj = Console.ReadLine();
        ValidateCNPJ(cnpj);

        Console.WriteLine("Digite o numero do titulo de eleitor (Sem ponto ou traço): ");
        string titulo = Console.ReadLine();
        ValidateTitulo(titulo);
        
        // Debug.WriteLine(new CPFFormatter().Format(cpfFormatado));
        // Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado);

    }

    private static void ValidateTitulo(string titulo)
    {
        if (new TituloEleitoralValidator().IsValid(titulo))
        {
            Console.WriteLine("Titulo de eleitor válido: " + titulo);

        }
        else
        {
            Console.WriteLine("Titulo de eleitor inválido: " + titulo);
        }
    }

    private static void ValidateCNPJ(string cnpg)
    {
        if (new CNPJValidator().IsValid(cnpg))
        {
            Console.WriteLine("CNPJ válido: " + cnpg);

        }
        else
        {
            Console.WriteLine("CNPJ inválido: " + cnpg);
        }
    }

    //Using IsValid
    private static void ValidateCPF(string cpf)
    {
        if (new CPFValidator().IsValid(cpf))
        {
            Console.WriteLine("CPF valido: " + cpf);
        }
        else
        {
            Console.WriteLine("CPF inválido: " + cpf);
        }
    }

    //Using AssertValid
    // private static void ValidateCPF(string cpf)
    // {
    //     try
    //     {
    //         new CPFValidator().AssertValid(cpf);
    //         // Debug.WriteLine("CPF valido: " + cpf);
    //         Console.WriteLine("CPF valido: " + cpf);
    //     }
    //     catch (System.Exception)
    //     {
    //         // Debug.WriteLine("CPF inválido: " + cpf);
    //         Console.WriteLine("CPF inválido: " + cpf);
    //     }
    // }
}