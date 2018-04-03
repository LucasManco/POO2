/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contacorrente;

/**
 *
 * @author lucas.desouza
 */
public class ContaCorrente extends Conta implements Tributavel{
    @Override
    public double calculaTributos(){
        return (getSaldo()*0.1);
    }
}
