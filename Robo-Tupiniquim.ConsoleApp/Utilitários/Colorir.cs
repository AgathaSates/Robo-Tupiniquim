namespace Robo_Tupiniquim.ConsoleApp.Utilitários;

class Colorir
{
    public static void EscreverEmVermelhoLinha(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(mensagem);
        Console.ResetColor();
    }

    public static void EscreverEmVermelhoEscuro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    public static string EscreverEmVermelhohistorico(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(mensagem);
        Console.ResetColor();
        return mensagem;
    } 
    public static void EscreverEmVermelho(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    } 
    
    public static void EscreverEmCiano(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    
    public static void EscreverEmAzul(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    
    public static void EscreverEmVerdeLento(char letra)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(letra);
        Console.ResetColor();
    }

    public static void EscreverEmVerde(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }

    public static void EscreverEmAmarelo(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }

    public static void EscreverEmAmareloEscuro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    } 

    public static void EscreverEmAmareloEscuroLinha(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(mensagem);
        Console.ResetColor();
    }
    public static void EscreverEmRosa(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    
    
    
}
