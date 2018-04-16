package geradortelefone;

public class ThreadSqlSingleTon implements Runnable
{
   @Override
   public void run()
   {
      System.out.println("next num:" + NumberGenerator.INSTANCE.getNextNum());
      System.out.println("next num:" + NumberGenerator.INSTANCE.getNextNum());
      System.out.println("next num:" + NumberGenerator.INSTANCE.getNextNum());
      System.out.println("next num:" + NumberGenerator.INSTANCE.getNextNum());
   }
}   
      