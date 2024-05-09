using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumoDeAPI.Models;

internal class Cidade
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("estado")]
    public string Estado { get; set; }

    public void ExibirCidade()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Estado: {Estado}");
    }
}

