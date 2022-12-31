namespace Drawing;

public class Line : Shape, Iprintable
{

    public Point StartLine { get; set; }
    public Point EndLine { get; set; }

    public Line()
    {
        this.StartLine = new Point(0, 0);
        this.EndLine = new Point(0, 0);
    }

    public Line(Point p1, Point p2)
    {
        this.StartLine = p1;
        this.EndLine = p2;
    }

    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("type: " + t.Nname);
        Console.WriteLine(this.StartLine + " " + this.EndLine);
        Console.WriteLine("Color:=" + this.Color);

    }

    public void Print()
    {
        Console.WriteLine("Printing object using  exiting printer");
        Type t = this.GetType();
        Console.WriteLine("Type =" + t.Name);
        Console.WriteLine("(" + this.StartPoint + "), (" + this.EndPoint + ")," +
       this.Width + "," + this.Color);
    }

}