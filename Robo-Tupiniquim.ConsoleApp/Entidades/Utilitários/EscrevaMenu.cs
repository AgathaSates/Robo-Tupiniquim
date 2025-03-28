namespace Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

class EscrevaMenu
{
    public static void Titulo()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("                Desbravamento de Marte");
        Console.WriteLine("---------------------------------------------------------");
    }

    public static void Menu()
    {

        EscreverLento("Bem-vindo à missão da AEB! Explore o Planeta Vermelho e \ndesbrave o desconhecido, tudo sem sair da Terra!");
        Thread.Sleep(800);
        Console.WriteLine(); 
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("1 - Iniciar Nova Missão de Exploração");
        Console.WriteLine("2 - Treinamento");      
        Console.WriteLine("3 - Desconectar");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Dica: Use o Treinamento para aprender a controlar o robô!");
        Console.WriteLine("---------------------------------------------------------");
        Console.Write("Escolha uma ação para continuar sua jornada: ");
    }

    public static void Treinamento()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("                        Treinamento de Controle");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("  Instruções: ");
        Console.WriteLine( );
        Console.WriteLine("1. Antes de começar, informe o tamanho da área que será explorada.");
        Console.WriteLine( );
        Console.WriteLine("  - O tamanho é informado com dois números: largura (X) e altura (Y).\n    Exemplo: '5 5'");
        Console.WriteLine(  );
        Console.WriteLine("  - O robô só poderá se mover dentro dessa área!");
        Console.WriteLine(  );
        Console.WriteLine("2.Após definir a área, informe a posição inicial do robô.");
        Console.WriteLine( );
        Console.WriteLine("  - A posição é informada com 3 dados:\n    X (posição horizontal), Y (posição vertical) e a direção do robô.");
        Console.WriteLine(  );
        Console.WriteLine("  - Exemplo de posição inicial: '1 2 N' significa que  o robô começa\n    na posição (1, 2) e está virado para o Norte.");
        Console.WriteLine();
        Console.WriteLine("  - Direções possíveis: N (Norte), S (Sul), L (Leste) e O (Oeste).");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("  Comandos: ");
        Console.WriteLine(   );
        Console.WriteLine("> [M] - Mover para frente");
        Console.WriteLine("> [E] - Virar à esquerda");
        Console.WriteLine("> [D] - Virar à direita");
        Console.WriteLine( );
        Console.WriteLine("- Os comandos devem ser digitados em sequência, sem espaços.");
        Console.WriteLine("  Exemplo: 'EMEMEMEMM' para executar uma série de movimentos.");
        Console.WriteLine(  );
        Console.WriteLine("- O robô seguirá a sequência de comandos e se moverá dentro dos\n  limites da área informada.");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("> Use 'M' para mover o robô e 'E'/'D' para girar à esquerda ou à direita.");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.Write("-> Pressione qualquer tecla para voltar ao menu:");
        Console.ReadKey();
    }

    public static void Desconectar()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("                       Desconectando...");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine(" A missão foi finalizada com sucesso. O robô retornou à base.");
        Console.WriteLine(" Até a próxima missão, explorador! \n Que as estrelas guiem seu caminho!");
        Console.WriteLine("----------------------------------------------------------------");

    }
   
    public static void EscreverLento(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
    }
}
