
package refeicao;

/**
 *
 * @author felip
 */
public class BuilderRefeicao {

    /**
     * @param args the command line arguments
    
    **/
    public static void main(String[] args) {
        // TODO code application logic here
         DiretorRefeicao criaRefeicao = new DiretorRefeicao();      
        //controi uma refeicao.
        Refeicao refeicao1 = criaRefeicao.preparaNaoVegetariana("laranja", "suco",false);                
        Refeicao refeicao2 = criaRefeicao.preparaVegetariana("guarana", "refrigerante",true);       
    }
   
}
