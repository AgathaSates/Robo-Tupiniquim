using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class IniciarExploracao
{
    public static void Explorar()
    {
        EscrevaExploracao.TituloIniciodaMissao();
        Area.PedirArea();
        PedirRobo.PedirDadosRobo1();
        PedirRobo.PedirDadosRobo2();
        EscrevaExploracao.MensagemInicioDaMissao();
        MovimentosRobo.MoverRobo(PedirRobo.nomeRobo1,PedirRobo.robo1comandos,PedirRobo.robo1direcao,PedirRobo.robo1x, PedirRobo.robo1y);
        Thread.Sleep(1500);
        MovimentosRobo.MoverRobo(PedirRobo.nomeRobo2,PedirRobo.robo2comandos,PedirRobo.robo2direcao,PedirRobo.robo2x, PedirRobo.robo2y);
        Thread.Sleep(1500);
        EscrevaExploracao.StatusFinaldaMissao();
        Console.ReadKey();
    }
}
