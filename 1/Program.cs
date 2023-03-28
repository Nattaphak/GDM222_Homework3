class Program
{
    static void Main(string[] args)
    {
        double xP1 = double.Parse(Console.ReadLine());
        double yP1 = double.Parse(Console.ReadLine());

        double xP2 = double.Parse(Console.ReadLine());
        double yP2 = double.Parse(Console.ReadLine());

        double xP3 = double.Parse(Console.ReadLine());
        double yP3 = double.Parse(Console.ReadLine());

        double h = ((yP2-yP1) * (yP3*yP3-yP1*yP1+xP3*xP3-xP1*xP1) + (yP3-yP1) * (yP1*yP1-yP2*yP2+xP1*xP1-xP2*xP2)) / (2 * (xP3-xP1) * (yP2-yP1) -2 * (xP2-xP1) * (yP3-yP1));
        double k = ((xP2-xP1) * (xP3*xP3-xP1*xP1+yP3*yP3-yP1*yP1) + (xP3-xP1) * (xP1*xP1-xP2*xP2+yP1*yP1-yP2*yP2)) / (2 * (yP3-yP1) * (xP2-xP1) -2 * (yP2-yP1) * (xP3-xP1));

        double r =Math.Sqrt((xP1-h) * (xP1-h) + (yP1-k) * (yP1-k));

        Console.WriteLine(h);
        Console.WriteLine(k);
        Console.WriteLine(r);
        
    }
}
