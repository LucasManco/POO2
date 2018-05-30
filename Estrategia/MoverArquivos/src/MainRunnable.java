
import java.io.File;
import java.io.IOException;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 20132bsi0133
 */
public class MainRunnable {
    
    
    
    public static void main(String args[]) throws IOException, InterruptedException {
        File listaFiles[] = null;
        
        
        final long startTime = System.currentTimeMillis();// tempo incial
        listaFiles = MoveFile.getSingleTonListaFiles(); //le arquivos do diretorio e coloca na listaFiles                
        Runnable runUUID1 = new MoveFileRunnable("Thread1",listaFiles);
        Thread thread1 = new Thread(runUUID1);
        System.out.println("Iniciando copiar de arquivos");
        thread1.start();
        
        final long elapsedTimeMillis = System.currentTimeMillis() - startTime; //tempo total de execução do programa
        System.out.println("Time:" + elapsedTimeMillis);

    }
}
