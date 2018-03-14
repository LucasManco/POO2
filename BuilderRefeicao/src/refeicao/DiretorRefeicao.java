
package refeicao;

/**
 *
 * @author felipe
 */
public class DiretorRefeicao {        
    
    /**
     *
     */
    
    public Refeicao preparaNaoVegetariana(String sabor, String tipoBebida, boolean batata){       
        Refeicao novaRefeicao = new Refeicao();
        NonVegetarianoBuilder refeicaoBuilder = new NonVegetarianoBuilder(novaRefeicao);        
        if(tipoBebida.equalsIgnoreCase("refrigerante"))
            refeicaoBuilder.adicionarRefrigerante(sabor);
        else
            refeicaoBuilder.adicionarSuco(sabor);                
        refeicaoBuilder.preparaHamburgerCarne();
        
        if(batata==true) refeicaoBuilder.preparaBatata();
        return novaRefeicao;        
    }     
    public Refeicao preparaVegetariana(String sabor, String tipoBebida, boolean batata){        
        Refeicao novaRefeicao = new Refeicao();
        VegetarianoBuilder refeicaoBuilder = new VegetarianoBuilder(novaRefeicao);        
        if(tipoBebida.equalsIgnoreCase("refrigerante"))
            refeicaoBuilder.adicionarRefrigerante(sabor);
        else
            refeicaoBuilder.adicionarSuco(sabor);     
        refeicaoBuilder.preparaHamburgerVegetariano();
        if(batata) {
            refeicaoBuilder.preparaBatata();
        }
        return novaRefeicao;        
    }            
    
}
