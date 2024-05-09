using ConsumoDeAPI.Filtros;
using ConsumoDeAPI.Models;
using System.Text.Json;

    using (HttpClient client = new HttpClient())
    {
        try
        {
            string resp = await client.GetStringAsync("https://brasilapi.com.br/api/cptec/v1/cidade");
            var cidades = JsonSerializer.Deserialize<List<Cidade>>(resp)!;

            string Titulo = "\r\n░█████╗░░█████╗░███╗░░██╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░  ██████╗░███████╗  ░█████╗░██████╗░██╗\r\n██╔══██╗██╔══██╗████╗░██║██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗██║\r\n██║░░╚═╝██║░░██║██╔██╗██║╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║  ██║░░██║█████╗░░  ███████║██████╔╝██║\r\n██║░░██╗██║░░██║██║╚████║░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║  ██║░░██║██╔══╝░░  ██╔══██║██╔═══╝░██║\r\n╚█████╔╝╚█████╔╝██║░╚███║██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║  ██████╔╝███████╗  ██║░░██║██║░░░░░██║\r\n░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ╚═╝░░╚═╝╚═╝░░░░░╚═╝";

            Console.WriteLine(Titulo);
            Console.WriteLine("\nDigite o numero da opção que deseja!");

            Console.WriteLine("\n1 - Filtrar cidade por nome");
            Console.WriteLine("\n2 - Filtrar cidade por sigla");
            Console.WriteLine("\n3 - Filtrar cidade por codigo");
            Console.WriteLine("\n4 - Gerar arquivo JSON com todas as cidades");

            string resporta = Console.ReadLine()!;
            int respostaInt = int.Parse(resporta);

            switch (respostaInt)
            {
                case 1:
                    Filter.FiltroNome(cidades);
                    break;
                case 2:
                    Filter.FiltroEstado(cidades);
                    break;
                case 3:
                    Filter.FiltroCod(cidades);
                    break;
                case 4:
                    Filter.GerarArquivoJson(cidades);
                break;
            }

    }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }




