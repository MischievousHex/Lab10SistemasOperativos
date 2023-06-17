public class Main {
    public static void main(String[] args) {

        LetraProceso s = new LetraProceso("S");
        LetraProceso a = new LetraProceso("A");
        LetraProceso l = new LetraProceso("L");
        LetraProceso t = new LetraProceso("T");
        LetraProceso o = new LetraProceso("O");
        LetraProceso enter = new LetraProceso("\n");

        s.start();
        s.sleep(10);
        a.start();
        a.sleep(10);
        l.start();
        l.sleep(10);
        t.start();
        t.sleep(10);
        o.start();
        o.sleep(10);
        enter.start();
        enter.sleep(10);
    }
}