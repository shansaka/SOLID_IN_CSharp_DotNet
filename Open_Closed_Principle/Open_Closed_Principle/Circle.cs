namespace Open_Closed_Principle;

// Derived clas
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}