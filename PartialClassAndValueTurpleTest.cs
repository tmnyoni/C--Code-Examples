/// <author>
/// Tawanda M. Nyoni github: hkay-tee
/// </author>
///
/// <summary>
/// Code for testing partial classes and use of valueTurple
/// </summary>

using System;
public partial class Cordinates
{
    private (double x, double y) point = (x: 0, y: 0);


    public Cordinates()
    {
        point.x = 10;
        point.y = 6;
    }
}

public partial class Cordinates
{
    public void printCordinates()
    {
        Console.WriteLine($"x = {point.x} \ny = {point.y}");
    }
}

public class Test
{
    public static void Main(String[] args)
    {
        Cordinates cords = new Cordinates();
        cords.printCordinates();
    }
}
