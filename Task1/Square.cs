 namespace Task1;
 
 public class Square : Rectangle
{
   public Square(){}
   public Square(double side) :base(side,side){
      side = GetWidth();
   }
    public Square(double side, string Color, bool filled ) : base(side,side, Color, filled){
        side = GetWidth();
    }
    
    public virtual double GetSide(){
        return GetLength();
    }

     public virtual void SetSide(double side){
        this.SetWitdh(side) ;
    }
      public override void SetLength(double side){
        base.SetLength(side);
    }

     public override void SetWitdh(double side){
        
       base.SetWitdh(side);
    }
    public override string ToString()
    {
        return base.ToString();
    }



}

   