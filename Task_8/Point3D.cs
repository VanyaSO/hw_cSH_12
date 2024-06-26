namespace Task_8;

public record class Point3D(double X, double Y, double Z)
{
    public double DistancePoints(Point3D point)
    {
        return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2) + Math.Pow(point.Z - Z, 2));
    }
}