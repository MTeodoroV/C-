using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using Caelum.Stella.CSharp.Http;
using System.Threading.Tasks;
// using Caelum.Stella.CSharp.Http.ViaCEP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o cep (Sem ponto ou traço): ");
        string cep = Console.ReadLine();
        // string result = GetEndereco(cep);

        ViaCEP viaCEP = new ViaCEP();
        string enderecoJson = viaCEP.GetEnderecoJson(cep);
        string enderecoXml = viaCEP.GetEnderecoXml(cep);
        var task = viaCEP.GetEnderecoJsonAsync(cep);

        // Console.WriteLine(enderecoJson); 
        // Console.WriteLine(enderecoXml);
        // Console.WriteLine(task.Result);

        var endereco = viaCEP.GetEndereco(cep);
        Console.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}, Cidade: {2}, Estado: {3}", endereco.Logradouro, endereco.Bairro, endereco.Localidade, endereco.UF));
    }

    private static string GetEndereco(string cep)
    {
        string url = "https://viacep.com.br/ws/" + cep + "/json/";

        string result = new HttpClient().GetStringAsync(url).Result;
        return result;
    }
}