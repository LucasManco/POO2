/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 20132bsi0133
 */
public class FlyweightStatusItem {
    StatusItem CARRINHO, FECHADO, PAGO, ENVIADO , ENTREGUE;

    public FlyweightStatusItem() {
        this.CARRINHO = new StatusItem(Estado.CARRINHO, true, false);
        this.FECHADO = new StatusItem(Estado.FECHADO, true, false);
        this.PAGO = new StatusItem(Estado.PAGO, true, true);
        this.ENVIADO = new StatusItem(Estado.ENVIADO, false, true);
        this.ENTREGUE = new StatusItem(Estado.ENTREGUE, false, true);
        
    }
    
    public StatusItem get(Estado estado) {
        switch(estado){
            case CARRINHO:
                return this.CARRINHO;
            case FECHADO:
                return this.FECHADO;
            case PAGO:
                return this.PAGO;
            case ENVIADO:
                return this.ENVIADO;
            case ENTREGUE:
                return this.ENTREGUE;
        }
        return null;
    }
}
