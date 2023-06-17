public class LetraProceso extends Thread
{
    private final String letra;

    public LetraProceso(String letra){
        this.letra = letra;
    }

    @Override
    public void run(){
        for(int i = 0; i < 10; i++) {
            System.out.print(letra);
            this.sleep(100);
        }
    }

    public void sleep(int ms){
        try{
            Thread.sleep(ms);
        } catch (InterruptedException ignored) {
        }
    }

}
