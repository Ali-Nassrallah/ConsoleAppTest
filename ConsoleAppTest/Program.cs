using System;
class Calculater
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1.Sum\n2.Sub\n3.Mul\n4.Div\n5.Exit");
        while (true)
        {
            
            int o = int.Parse(Console.ReadLine());
            if(o == 5) {
                Console.WriteLine("Thank You.");
                break;
            }
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            if (o == 1)
            {
                Console.Write("x + y = " + x + y);
            }
            else if (o == 2)
            {
                double s = x - y;
                Console.Write("x - y = " + s);
            }
            else if (o == 3)
            {
                Console.Write("x * y = " + x * y);
            }
            else
            {
                Console.Write("x / y = " + x / y);
            }
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Sum \n2.Sub\n3.Mul\n4.Div\n5.Exit");
        }
           
    }
}

