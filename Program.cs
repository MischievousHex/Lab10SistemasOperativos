// See https://aka.ms/new-console-template for more information

using SisOpsLab10;

public static class Program
{
    public static void Main(String[] args)
    {
        HiloPorLetra Ese = new HiloPorLetra("Ese", "S");
        HiloPorLetra AA = new HiloPorLetra("Aaa", "A");
        HiloPorLetra Ele = new HiloPorLetra("Ele", "L");
        HiloPorLetra TTte = new HiloPorLetra("TTte", "T");
        HiloPorLetra Ooo = new HiloPorLetra("Ooo", "O");
        HiloPorLetra Enter = new HiloPorLetra("Enter", "\n");
        HiloPorLetra espacio = new HiloPorLetra("Espacio", " ");
        HiloPorLetra punto = new HiloPorLetra("punto", ".");
        
        punto.Run();
        Thread.Sleep(10);
        espacio.Run();
        Thread.Sleep(10);
        Ese.Run();
        Thread.Sleep(10);
        AA.Run();
        Thread.Sleep(10);
        Ele.Run();
        Thread.Sleep(10);
        TTte.Run();
        Thread.Sleep(10);
        Ooo.Run();
        Thread.Sleep(10);
        Enter.Run();
        Thread.Sleep(10);

    }
}