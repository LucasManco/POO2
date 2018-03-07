/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shapefactory;

import static java.time.Clock.system;

/**
 *
 * @author 20132bsi0133
 */
public class main {
    public static void main(String[] args) {
      Shape shape;
      shape = ShapeFactory.newShape("shapefactory.Shapes.Circle");
      shape.draw();
      
      shape = ShapeFactory.newShape("shapefactory.Shapes.Triangle");
      shape.draw();
      
      shape = ShapeFactory.newShape("shapefactory.Shapes.Square");
      shape.draw();
    }
}
