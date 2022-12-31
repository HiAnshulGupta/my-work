namespace Drawing;

public enum Color { RED, GREEN, BLUE };
public class Shape
{

    public int Width { get; set; }

    public Color Color { get; set; }

    public abstract void Draw();
}