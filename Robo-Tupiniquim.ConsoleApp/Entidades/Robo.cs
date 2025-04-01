using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Robo
{
    public string nome;
    public int posicaox;
    public int posicaoy;
    public char direcao;
    public string comandos;

    public void PedirDados()
    {
        EscrevaExploracao.PedirNomeRobo1();
        nome = Validadores.EhumNomeValido();

        EscrevaExploracao.PedirPosicaoRobo1(nome);
        string[] posicaoInicial = Validadores.EhumaPosicaoValida().Split(' ');
        posicaox = int.Parse(posicaoInicial[0]);
        posicaoy = int.Parse(posicaoInicial[1]);
        direcao = char.Parse(posicaoInicial[2]);

        EscrevaExploracao.PosicaoInicialRobo(nome, posicaox, posicaoy, direcao);

        Colorir.EscreverEmAmareloEscuroLinha("-> Digite os comandos (E=esquerda, D=direita, M=mover) de forma sequencial: ");
        comandos = Validadores.EhumComandoValido();
    }

    public void MoverRobo()
    {
        foreach (char comando in comandos)
        {
            switch (comando)
            {
                case 'M': Avançar(); break;

                case 'E': direcao = VirarParaEsquerda(); break;

                case 'D': direcao = VirarParaDireita(); break;
            }
        }

        if (posicaox < 0 || posicaox > Area.LimiteX || posicaoy < 0 || posicaoy > Area.LimiteY)
            EscrevaExploracao.UltrapassouArea(nome, posicaox, posicaoy, direcao);

        else
            EscrevaExploracao.PosicaoFinalRobo(nome, posicaox, posicaoy, direcao);
    }

    public void Avançar()
    {
        switch (direcao)
        {
            case 'N': posicaoy++; break;

            case 'S': posicaoy--; break;

            case 'L': posicaox++; break;

            case 'O': posicaox--; break;
        }
    }

    public char VirarParaEsquerda()
    {
        switch (direcao)
        {
            case 'N': return 'O';

            case 'L': return 'N';

            case 'S': return 'L';

            case 'O': return 'S';

            default: return '?';
        }
    }

    public char VirarParaDireita()
    {
        switch (direcao)
        {
            case 'N': return 'L';

            case 'L': return 'S';

            case 'S': return 'O';

            case 'O': return 'N';

            default: return '?';
        }
    }
}
