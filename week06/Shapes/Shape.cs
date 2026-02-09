using System.Drawing;

public abstract class Shape
{
    private string _paperColor = "";

    public Shape(string color)
    {
        _paperColor = color;
    }

    public string GetColor()
    {
        return _paperColor;
    }

    public void SetColor(string color)
    {
        _paperColor = color;
    }

    public abstract double GetArea();
}
