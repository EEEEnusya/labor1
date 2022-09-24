 namespace Task3;
 public class Point
{
    int x;
    int y;
    public Point(int x1, int y1)
    {
        this.x = x1;
        this.y = y1;
    }
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
}

 public class  Figure
{
    Point p1;
    Point p2;
    Point p3;   
    Point p4;
    Point p5;
    public string Name { get; set; }

    public Figure(Point p1_, Point p2_, Point p3_, Point? p4_=null, Point? p5_ = null)
    {
        this.p1 = p1_;
        this.p2 = p2_;
        this.p3 = p3_;
        this.p4 = p4_;
        this.p5 = p5_;
        if (p4 == null)
        {
            Name = "Triengle";
        }
        if ( p5 == null && p4 != null)
        {
            Name = "Qadrilateral";
        }
        if (p5 != null && p4 != null)
        {
            Name = "Pentagon";
        }
    }
    public double Landside ( Point a, Point b)
    {
        double L=Math.Sqrt((a.X-b.X)* (a.X-b.X) + (a.Y-b.Y)*(a.Y-b.Y));
        return L;
    }
    public double PerimetrMnogougol()
    {
        if ( Name == "Triengle")
        {
            double per=Landside(p1,p2)+Landside(p2,p3)+Landside(p1,p3);
            Console.WriteLine($"Периметр Triengle ={per}"); 
            return per;
        }
        if ( Name == "Quadrilateral")
        {
            double perQ=Landside(p1,p2)+Landside(p2,p3)+Landside(p3,p4)+Landside(p4,p1);
            Console.WriteLine($"Периметр Quardlateral= {perQ}");
            return perQ;
        }
        if ( Name == " Pentagon")
        {
            double perpen=Landside(p1,p2)+Landside(p2,p3)+Landside(p3,p4)+Landside(p4,p5)+Landside(p5,p1);
            Console.WriteLine($"Периметр Pentagon = {perpen}"); 
            return perpen;
        }
        return 0;
    }
 }

