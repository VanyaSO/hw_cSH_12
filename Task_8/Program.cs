namespace Task_8;
// Створіть запис Point3D. Необхідно зберігати інформацію про координати точки у тривимірному просторі.
// Створіть масив точок. Напишіть код для обчислення
// відстані між точками. Відобразіть максимальну відстань
// між точками та інформацію про них.


public static class ListExtensions
{
    // получаем и число и точки 
    public static double MaxDistancePoints(this List<Point3D> list, out Point3D pointF, out Point3D pointS)
    {
        if (list.Count == 0)
            throw new ArgumentException("Масив пуст");

        pointF = list[0];
        pointS = list[1];
        
        double maxDistance = 0;
        
        for (int i = 0; i < list.Count; i++)
            for (int j = 0; j < list.Count; j++)
            {
                double newDistance = list[i].DistancePoints(list[j]);
                if (newDistance > maxDistance)
                {
                    maxDistance = newDistance;
                    pointF = list[i];
                    pointS = list[j];
                }
            }
                    
        return maxDistance;
    }
    
    // просто число получаем
    public static double MaxDistancePoints(this List<Point3D> list)
    {
        if (list.Count == 0)
            throw new ArgumentException("Масив пуст");
        
        double maxDistance = 0;
        for (int i = 0; i < list.Count; i++)
            for (int j = i + 1; j < list.Count; j++)
            {
                double newDistance = list[i].DistancePoints(list[j]);
                if (newDistance > maxDistance)
                {
                    maxDistance = newDistance;
                }
            }

        return maxDistance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Point3D> listPoints = new List<Point3D>() {new Point3D(41.0, 5.0, 6.0), new Point3D(46.0, 2.0, 3.0),  new Point3D(4.0, 51.0, 6.0)};
        
        Point3D p1, p2;
        double maxDistance = listPoints.MaxDistancePoints(out p1, out p2);
        
        Console.WriteLine($"Самое большое растояние между точками {p1} и {p2} = {maxDistance}");
        Console.WriteLine($"Самое большое растояние {listPoints.MaxDistancePoints()}");
    }
}