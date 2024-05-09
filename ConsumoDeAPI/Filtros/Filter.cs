
using ConsumoDeAPI.Models;
using System.Text.Json;
namespace ConsumoDeAPI.Filtros;



internal class Filter
{
    Cidade cid = new Cidade();
    public static void GerarArquivoJson(List<Cidade> cidades) // Serializando um json 
    {

        string json = JsonSerializer.Serialize(new
        {
            Cidade = cidades
        });
        string nomeDoArquivo = $"Cidades-estados.json";

        File.WriteAllText(nomeDoArquivo, json); // criando arquivo
        Console.WriteLine(Path.GetFullPath(nomeDoArquivo));
    }

    

    public static void FiltroNome(List<Cidade> cidades)
    {
        Console.Clear();

        Console.WriteLine("Digite o nome da cidade:\n");
        string cidade = Console.ReadLine()!;

        var AllNames = cidades.Where(c => c.Nome.StartsWith(cidade)).Distinct().ToList();

        foreach (var Cidades in AllNames) 
        {
            Console.WriteLine($"\n - {Cidades.Nome}");
            Console.WriteLine(Cidades.Id);
            Console.WriteLine(Cidades.Estado);
        }

        Console.WriteLine("Deseja gerar arquivo Json com essa informação?\n 1 Sim\n 2 Não");
        string resp = Console.ReadLine()!;
        int respInt = int.Parse(resp);
        if (respInt == 1) { GerarArquivoJson(AllNames); } else { Environment.Exit(0); }
    }

    public static void FiltroEstado(List<Cidade> cidades)
    {
        Console.Clear();

        Console.WriteLine("Digite a sigla do estado:\n");
        string estado = Console.ReadLine()!.ToUpper();

        var AllNames = cidades.Where(c => c.Estado.StartsWith(estado)).Distinct().ToList();

        foreach (var Estados in AllNames)
        {
            Console.WriteLine($"\n - {Estados.Nome}");
            Console.WriteLine(Estados.Id);
            Console.WriteLine(Estados.Estado);
        }

        Console.WriteLine("Deseja gerar arquivo Json com essa informação?\n 1 Sim\n 2 Não");
        string resp = Console.ReadLine()!;
        int respInt = int.Parse(resp);
        if (respInt == 1) { GerarArquivoJson(AllNames); } else { Environment.Exit(0); }
    }

    public static void FiltroCod(List<Cidade> cidades)
    {
        Console.Clear();

        Console.WriteLine("Digite o codigo da cidade:\n");
        string codigo = Console.ReadLine()!;
        int codigoInt = int.Parse(codigo);

        var AllNames = cidades.Where(c => c.Id.Equals(codigoInt)).Distinct().ToList();

        foreach (var Codigos in AllNames)
        {
            Console.WriteLine($"\n - {Codigos.Nome}");
            Console.WriteLine(Codigos.Id);
            Console.WriteLine(Codigos.Estado);
        }

        Console.WriteLine("Deseja gerar arquivo Json com essa informação?\n 1 Sim\n 2 Não");
        string resp = Console.ReadLine()!;
        int respInt = int.Parse(resp);
        if (respInt == 1) { GerarArquivoJson(AllNames); } else { Environment.Exit(0); }


    }


    
}


