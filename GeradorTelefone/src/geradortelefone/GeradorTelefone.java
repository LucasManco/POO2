/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package geradortelefone;

/**
 *
 * @author 20132bsi0133
 */
public class GeradorTelefone {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
{
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
      usingThreads();
  }
  
  public static void usingThreads(){
      
      Runnable hello = new ThreadSqlSingleTon();
      Thread thread1 = new Thread(hello);                  
      thread1.start();                  
  }

   
    
}
