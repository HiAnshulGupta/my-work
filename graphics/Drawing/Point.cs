namespace Drawing;

public struct Point{

    public int X{get;set;}
    public int Y{get;set;}

    public Point(int x,int y){
        this.X=X;
        this.Y=Y;
    }

     public override string ToString()
    {
        return  "(X="+this.X+ ", Y="+this.Y+ ")";
        
    }
}