/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shapefactory;

/**
 *
 * @author 20132bsi0133
 */
public class ShapeFactory {
    public static Shape newShape(String classe){
        Shape shape;
        Object classeReflection = null;
	try {
            classeReflection = Class.forName(classe).newInstance();            
	    } catch (InstantiationException e) {
	    e.printStackTrace();
	} catch (IllegalAccessException e) {
            e.printStackTrace();
	} catch (ClassNotFoundException e) {
	    e.printStackTrace();
	}        
        shape = (Shape) classeReflection;
        return shape;
    }
}
