package geradortelefone;


public enum NumberGenerator {
    INSTANCE;
    
    private int count =999990101;
    
    public synchronized int getNextNum(){
        return ++count;
    }
    
}
