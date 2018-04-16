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
public class Aeroporto {
    String codigo;
    String nome;
    Boolean eInternacional; //1 - internacional 0 - nacional
    Aeroporto[] destino;//lista de aeroportos que possuem voos para ele
    Aeroporto[] origem;//lista de aeroportos que ele possui voo direto
    Aviao[] noPatio;

    public Aeroporto(String codigo, String nome) {
        this.codigo = codigo;
        this.nome = nome;
    }

    public Boolean geteInternacional() {
        return eInternacional;
    }

    public void seteInternacional(Boolean eInternacional) {
        this.eInternacional = eInternacional;
    }

    public boolean equals (Aeroporto x){
        return x.codigo == null ? this.codigo == null : x.codigo.equals(this.codigo);
    }
    
    public boolean isIn (String codigo){
        for (Aviao noPatio1 : noPatio) {
            if (noPatio1.getPrefixo() == null ? codigo == null : noPatio1.getPrefixo().equals(codigo)) {
                return true;
            }
        }
        return false;
    }
    
    public boolean possuiRota(Aeroporto aeroporto){
        for (Aeroporto origem1 : aeroporto.origem) {
            if (origem1.equals(this)) return true; 
            for (Aeroporto origem2 : origem1.origem) {
                if (origem2.equals(this)) return true; 
            }
        }
        return false;
    }


    
    
    
}
