using System.Globalization;
using System.Text.RegularExpressions;

namespace Robo_Tupiniquim.ConsoleApp.Utilitários;

class Validadores
{  
    public static int EhUmaOpcaodoMenu(int min, int max)
    {
        int opcaovalida;
        string opcao = Console.ReadLine()!;
        while (!int.TryParse(opcao, out  opcaovalida) || opcaovalida < min || opcaovalida > max)
        {
            Colorir.EscreverEmVermelhoLinha(" -> (X) Opção inválida! Digite novamente: ");
            opcao = Console.ReadLine()!;
        }
        return opcaovalida;
    }

    public static string EhUmaAreaValdia()
    {
        
        string opcao = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(opcao) || !Regex.IsMatch(opcao, @"^\d+\s\d+$")) // valida apenas numeros separados por 1 espaço
        {
            Colorir.EscreverEmVermelhoLinha(" -> (X) Informação não reconhecida, digite novamente conforme orientado: ");
            opcao = Console.ReadLine()!;
        }
        return opcao;
    }

    public static string EhumNomeValido()
    {
        string name = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 30)
        {
            Colorir.EscreverEmVermelhoLinha(" -> (X) Nome inválido! Digite novamente: ");
            name = Console.ReadLine()!;
        }
        name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        return name;
    }

    public static string EhumComandoValido()
    {
        string comando = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(comando) || !Regex.IsMatch(comando, @"^[MmDdEe]+$")) // valida apenas M, D ou E
        {
            Colorir.EscreverEmVermelhoLinha(" -> (X) Comando inválido! Digite novamente conforme orientado: ");
            comando = Console.ReadLine()!;
        }
        return comando.ToUpper();
    }

    public static string EhumaPosicaoValida()
    {
        string posicao = Console.ReadLine()!;
        while (string.IsNullOrWhiteSpace(posicao) || !Regex.IsMatch(posicao, @"^\d+\s\d+\s[NnSsLlOo]$")) // valida numeros separados por espaço e uma letra N, S, L ou O
        {
            Colorir.EscreverEmVermelhoLinha(" -> (X) Posição inválida! Digite novamente conforme orientado: ");
            posicao = Console.ReadLine()!;
        }
        return posicao.ToUpper();
    }
}
