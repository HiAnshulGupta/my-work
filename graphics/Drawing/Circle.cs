namespace Drawing;

public class Circle:Shape,Iprintable{

    public Point Center{get; set;}
    public int radius{get; set;}

    public Circle(){
        this .Center=new Point(0,0);
        this.radius=1;
    }

    public Circle(Point c,int r){
        this .Center=c;
        this.radius=r;
    }

    public override void Draw()
    {
        //Getting metadata using reflection 
        
        Type t=this.GetType();
        Console.WriteLine("Type ="+ t.Name);

        Console.WriteLine("("+ this.Center+ "), Radius=" +this.Radius+ ","+
                            this.Width+"," + this.Color);
    }


    public void Print(){
            Console.WriteLine("Printing object on existing printer");
            Type t=this.GetType();
            Console.WriteLine("Type ="+ t.Name);
            Console.WriteLine("("+ this.Center+ "), Radius=" +this.Radius+ ","+
                            this.Width+"," + this.Color);
        }



}