namespace Task1;

public class Circle : Shape {
   protected double radius = 1.0;
   public Circle(){}
   public Circle(double radius){
    this.radius = radius;
   }
    public Circle(double radius, string Color, bool filled) :base( Color, filled){
    this.radius = radius;
    
   }
    public double GetRadius(){
        return radius;
    }
     public void SetRadius(){
        this.radius = radius;
    }
    public override double GetArea(){
        return radius * radius * 3.14;
    }
    public override double GetPerimeter(){
        return 2 * 3.14 * radius;
    }
    public override string ToString()
    {
        return $"[{base.ToString()}] , radius {radius}" ;
    }



}

