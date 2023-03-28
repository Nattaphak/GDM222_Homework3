class Program
{
    static void Main(string[] args)
    {
        List<Vector2> point = new List<Vector2>();
        bool CheckInside = true;

        for(int i = 0; i <= 0;)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if(x != 0 || y != 0)
            {
                point.Add(new Vector2(x ,y));
            }

            else
            {
                i++;
            }
            
        }

        double xK = double.Parse(Console.ReadLine());
        double yK = double.Parse(Console.ReadLine());

        int n = 0;
        while( n < point.Count() && CheckInside == true)
        {
            if(n != point.Count()-1)
            {
                double slope = (point[point.Count()-1].y - point[0].y)/(point[point.Count()-1].x - point[0].x);
                if(slope < 0)
                {
                    if(((1 / slope) * yK) - (xK) <= (1 / slope) * point[n].y - (point[n].x)) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * yK) - (xK) > (1 / slope) * point[n].y - (point[n].x))
                    {
                        break;
                    }
                }
                else
                {
                    if(((1 / slope) * yK) - (xK) <= (1 / slope) * point[n].y - (point[n].x))  
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * yK) - (xK) > (1 / slope) * point[n].y - (point[n].x))
                    {
                        CheckInside = false;
                        break;
                    }
                }   
            }

             else if(n == point.Count()-1)
            {
                double slope = (point[point.Count()-1].y - point[0].y)/(point[point.Count()-1].x - point[0].x);

                 if(slope < 0)
                {
                    if(((1 / slope) * yK) - (xK) <= (1 / slope) * point[n].y - (point[n].x)) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * yK) - (xK) > (1 / slope) * point[n].y - (point[n].x))
                    {
                        break;
                    }
                }
                else
                {
                    if(((1 / slope) * yK) - (xK) <= (1 / slope) * point[n].y - (point[n].x))  
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * yK) - (xK) > (1 / slope) * point[n].y - (point[n].x))
                    {
                        CheckInside = false;
                        break;
                    }
                } 
            }
            n++;
        }
         if(CheckInside == true) 
        {
            Console.WriteLine("Inside");
        }
        else if(CheckInside == false)
        {
            Console.WriteLine("Outside");
        }
    }
}