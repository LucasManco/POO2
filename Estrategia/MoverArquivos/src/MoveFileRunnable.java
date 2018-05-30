import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 20132bsi0133
 */
public class MoveFileRunnable implements Runnable {
    String threadName;
    int indice = 0;
    private File listaFiles[] = null;
    
    /**
     *
     * @param threadName
     * @param listaFiles
     */
    public MoveFileRunnable(String threadName, File[] listaFiles)
    {
      this. listaFiles = listaFiles;
      this.threadName = threadName;
    }
    
    @Override
    public void run() {
        int i = getIndice();
        while (i> listaFiles.length){
            File origem = new File(listaFiles[i].getAbsolutePath());
            String destinationFile = listaFiles[i].getAbsolutePath();
            destinationFile = destinationFile.replace("origem", "destino");
            try {
                MoveFile.copyFile(origem, new File(destinationFile));
            } catch (IOException ex) {
                Logger.getLogger(MoveFileRunnable.class.getName()).log(Level.SEVERE, null, ex);
            }    
        }
    }
    
    public synchronized int getIndice(){
        indice++;
        return indice;
    }
    
    
    
}
