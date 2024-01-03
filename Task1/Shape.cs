namespace Task1;

public abstract class Shape{

   protected string Color = "red";
   protected bool Filled = true;
   public Shape(){}
    public Shape(string color, bool filled){
        this.Color = color;
        this.Filled = filled;
    }
    public string getColor(){
        return Color;
    }
     public void setColor(string color){
        this.Color = color;
    }
    public Boolean isFilled(){
        return Filled;
    }
    public void setFilled(bool filled){
        this.Filled = filled;

    }
    
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $" Shape {Color} {Filled}";
    }


}
