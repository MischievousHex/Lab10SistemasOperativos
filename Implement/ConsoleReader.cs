namespace SisOpsLab10.Implement;

public class ConsoleReader : IReader
{
    public String ReadString(String mensaje)
    {
        Console.WriteLine(mensaje);
        String? input = String.Empty;
        while(String.IsNullOrEmpty(input))
            input = Console.ReadLine();
        return input;
    }
}