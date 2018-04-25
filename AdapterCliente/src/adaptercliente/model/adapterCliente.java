/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package adaptercliente.model;

import lib.ClienteExterno;

/**
 *
 * @author 20132bsi0133
 */
public class adapterCliente implements ICliente {
    private ClienteExterno cliente;
    
    @Override
    public String getNomeCompleto() {
        return (cliente.getNome()+cliente.getSobreNome());
    }

    @Override
    public void setNomeCompleto(String nomeCompleto) {
        cliente.setNome(nomeCompleto.split(" ")[0]);
        cliente.setSobreNome(nomeCompleto.split(" ")[1]);
    }

    @Override
    public String getTelefone() {
        return (cliente.getDddTelefone()+cliente.getTelefone());
    }

    @Override
    public void setTelefone(String telefone) {
        cliente.setDddTelefone(telefone.split(" ")[0]);
        cliente.setTelefone(telefone.split(" ")[1]);
    }

    @Override
    public String getEmail() {
        return cliente.getEmail();
    }

    @Override
    public void setEmail(String email) {
        cliente.setEmail(email);
    }

    @Override
    public String getCelular() {
        return (cliente.getDddCelular()+cliente.getDddCelular());
    }

    @Override
    public void setCelular(String celular) {
        cliente.setDddCelular(celular.split(" ")[0]);
        cliente.setCelular(celular.split(" ")[1]);
    }

    public adapterCliente(ClienteExterno cliente) {
        this.cliente = cliente;
    }
}
