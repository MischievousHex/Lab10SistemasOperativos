using System.Threading;

namespace SisOpsLab10;

public class HiloPorLetra
{
    private String _name;
    private String _letra;
    private Thread _thread;

    public void SetLetra(String letra)
    {
        if (letra.Length == 1)
            this._letra = letra;
        else 
            throw new ArgumentException();
    }

    public HiloPorLetra(String nombre, String letra)
    {
        this._name = nombre;
        this._letra = letra;
        this._thread = new Thread(Run);
    }

    public void ImprimirLetra() {
        Console.Write(_letra);
    }

    public void HacerLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            ImprimirLetra();
            Thread.Sleep(100);
        }
    }
    
    public void Run() {
        HacerLoop();
    }

    public void Start() {
        this._thread.Start();
    }

    public void Sleep(int ms) {
        Thread.Sleep(ms);
    }

    public void Interrupt() {
        this._thread.Interrupt();
    }
    
    public void Join() {
        this._thread.Join();
    }

}