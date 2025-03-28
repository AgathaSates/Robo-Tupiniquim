using Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class IniciarMissao
{
    public static void Iniciar_Missao()
    {
        EscrevaSobreaMissao.TituloIniciodaMissao();
        Area.PedirArea();
        PedirRobo.PedirDadosRobo1();
        PedirRobo.PedirDadosRobo2();
        EscrevaSobreaMissao.MensagemInicioDaMissao();
        MovimentosRobo.MoverRobo(PedirRobo.nomeRobo1,PedirRobo.robo1comandos,PedirRobo.robo1direcao,PedirRobo.robo1x, PedirRobo.robo1y);
        Thread.Sleep(1500);
        MovimentosRobo.MoverRobo(PedirRobo.nomeRobo2,PedirRobo.robo2comandos,PedirRobo.robo2direcao,PedirRobo.robo2x, PedirRobo.robo2y);
        Thread.Sleep(1500);
        EscrevaSobreaMissao.StatusFinaldaMissao();
        Console.ReadKey();
    }
}
