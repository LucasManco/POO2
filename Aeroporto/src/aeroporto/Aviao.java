/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aeroporto;


/**
 *
 * @author lucas.desouza
 */
public class Aviao {
    private String prefixo;
    private String modelo;
    private String fabricante;
    private int qassentos;
    private int qassentosOcupados;
    
    public void setPrefixo(String prefixo){
        this.prefixo = prefixo;
    }
    
    public String getPrefixo (){
        return prefixo;
    }
    
    public void setModelo(String modelo){
        this.modelo = modelo;
    }
    
    public String getModelo (){
        return modelo;
    }
    
    public void setFabricante(String fabricante){
        this.fabricante = fabricante;
    }
    
    public String getFabricante (){
        return fabricante;
    }
    
    public void setQassentos(int qassentos){
        this.qassentos = qassentos;
    }
    
    public int getQassentos (){
        return qassentos;
    }
    
    public void setQassentosOcupados(int qassentosOcupados){
        this.qassentosOcupados = qassentosOcupados;
    }
    
    public int getQassentosOcupados (){
        return qassentosOcupados;
    }
}
