/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package revisaooo;

/**
 *
 * @author lucas.desouza
 */
public class ContaPoupanca extends Conta implements Tributavel{
    
    private double juros;
    /**
     *
     * @return
     */
    public double getJuros(){
        return juros;
    }
    public void setJuros(double juros){
        this.juros = juros;
    }
    
    @Override
    public double calculaTributos(){
        return (getSaldo()*0.1);
    }
    
    
    
    
}
