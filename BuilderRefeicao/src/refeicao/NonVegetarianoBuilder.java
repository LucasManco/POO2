

package refeicao;

/**
 *
 * @author felip
 */
public class NonVegetarianoBuilder extends RefeicaoBuilder{
 
    public NonVegetarianoBuilder(Refeicao novaRefeicao){
        this.refeicao = novaRefeicao;
    }    
    public void preparaHamburgerCarne(){
        System.out.println("cria hamburger carne");
        this.refeicao.setHamburger(new HamburgerCarne());                
    }
    public void preparaBatata(){
        System.out.println("cria Batata");
        this.refeicao.setBatata(new Batata());                
    }
}
