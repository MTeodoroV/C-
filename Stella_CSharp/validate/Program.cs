using System;
using System.Diagnostics;
using Caelum.Stella.CSharp.Validation;

class Program
{
    static void Main(string[] args)
    {
        string cpf = "86288366757";
        ValidateCPF(cpf);

        string cnpj = "51241758000152";
        ValidateCNPJ(cnpj);

        string titulo = "041372570132";
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