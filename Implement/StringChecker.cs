namespace SisOpsLab10.Implement;

public class StringChecker : IChecker
{
    public bool CheckString(String letra)
    {
        return letra.Length == 1;
    }
}