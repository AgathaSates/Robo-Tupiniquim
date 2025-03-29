namespace Robo_Tupiniquim.ConsoleApp.Utilitários;

class EscrevaMenu
{
    public static void Titulo()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmVermelho("---------------------------------------------------------");
        Colorir.EscreverEmVermelho("                    Desbrave Marte");
        Colorir.EscreverEmVermelho("   Com os Robôs Tupiniquim da Academia do Programador!");
        Colorir.EscreverEmVermelho("---------------------------------------------------------");
    }

    public static void Menu()
    {
        EscreverLento("Bem-vindo à missão da AEB! Explore o Planeta Vermelho e \ndesbrave o desconhecido, tudo sem sair da Terra!");
        Thread.Sleep(800);
        Console.WriteLine(); 
        Colorir.EscreverEmAmarelo("---------------------------------------------------------");
        Colorir.EscreverEmAmarelo("1 - Iniciar Nova Missão de Exploração");
        Colorir.EscreverEmAmarelo("2 - Treinamento");      
        Colorir.EscreverEmAmarelo("3 - Missões Concluídas");      
        Colorir.EscreverEmAmarelo("4 - Desconectar");
        Colorir.EscreverEmAmarelo("---------------------------------------------------------");
        Colorir.EscreverEmRosa("Dica: Use o Treinamento para aprender a controlar o robô!");
        Colorir.EscreverEmAmarelo("---------------------------------------------------------");
        Colorir.EscreverEmAmareloEscuroLinha("> Escolha uma ação para continuar sua jornada: ");
    }

    public static void Treinamento()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("--------------------------------------------------------------------------");
        Colorir.EscreverEmAzul("                        Treinamento de Controle");
        Colorir.EscreverEmAzul("--------------------------------------------------------------------------");
        Colorir.EscreverEmVerde("                               Instruções");
        Console.WriteLine();
        Colorir.EscreverEmAmareloEscuro("OBS: O processo é realizado com dois robôs, e você precisará definir as \n posições iniciais e comandos para ambos.");
        Console.WriteLine(  );
        Colorir.EscreverEmCiano("1. Antes de começar, informe o tamanho da área que será explorada.");
        Console.WriteLine();
        Colorir.EscreverEmAmareloEscuro("  - O tamanho é informado com dois números: largura (X) e altura (Y).\n    Exemplo: '5 5'");
        Console.WriteLine(  );
        Colorir.EscreverEmAmareloEscuro("  - Os robôs só poderão se mover dentro dessa área!");
        Console.WriteLine(  );
        Colorir.EscreverEmCiano("2.Após definir a área, informe a posição inicial do robô.");
        Console.WriteLine( );
        Colorir.EscreverEmAmareloEscuro("  - A posição é informada com 3 dados:\n    X (posição horizontal), Y (posição vertical) e a direção do robô.");
        Console.WriteLine(  );
        Colorir.EscreverEmAmareloEscuro("  - Exemplo de posição inicial: '1 2 N' significa que  o robô começa\n    na posição (1, 2) e está virado para o Norte.");
        Console.WriteLine();
        Colorir.EscreverEmAmareloEscuro("  - Direções possíveis: N (Norte), S (Sul), L (Leste) e O (Oeste).");
        Colorir.EscreverEmCiano("--------------------------------------------------------------------------");
        Colorir.EscreverEmVerde("                                Comandos");
        Console.WriteLine(   );
        Colorir.EscreverEmCiano("> [M] - Mover para frente");
        Colorir.EscreverEmCiano("> [E] - Virar à esquerda");
        Colorir.EscreverEmCiano("> [D] - Virar à direita");
        Console.WriteLine( );
        Colorir.EscreverEmAmareloEscuro("- Os comandos devem ser digitados em sequência, sem espaços.");
        Colorir.EscreverEmAmareloEscuro("  Exemplo: 'EMEMEMEMM' para executar uma série de movimentos.");
        Console.WriteLine(  );
        Colorir.EscreverEmAmareloEscuro("- O robô seguirá a sequência de comandos e se moverá dentro dos\n  limites da área informada.");
        Colorir.EscreverEmAzul("--------------------------------------------------------------------------");
        Colorir.EscreverEmVerde("-> Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }

    public static void Desconectar()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmVermelhoEscuro("----------------------------------------------------------------");
        Colorir.EscreverEmVermelhoEscuro("                       Desconectando...");
        Colorir.EscreverEmVermelhoEscuro("----------------------------------------------------------------");
        Thread.Sleep(1000);
        Colorir.EscreverEmAmareloEscuro(">> Encerrando a conexão com a AEB...");
        Thread.Sleep(1500);
        Colorir.EscreverEmVerde(" A missão foi finalizada com sucesso. Os robôs retornaram à base.");
        Colorir.EscreverEmVerde(" Até a próxima missão, explorador! \n Que as estrelas guiem seu caminho! o/");
        Colorir.EscreverEmVerde("----------------------------------------------------------------");
    }
   
    public static void EscreverLento(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Colorir.EscreverEmVerdeLento(c);
            Thread.Sleep(20);
        }
    }
}
