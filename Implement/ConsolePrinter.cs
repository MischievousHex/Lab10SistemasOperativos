namespace SisOpsLab10.Implement;

public class ConsolePrinter : IPrinter
{
    private StringChecker _stringChecker;

    public ConsolePrinter()
    {
        _stringChecker = new StringChecker();
    }
    
    public void Print(String texto)
    {
        if(_stringChecker.CheckString(texto))
            Console.Write(texto);
    }
}