using System;

namespace methods
{
    public class Calculator
    {
        public int Add(params int [] numbers)
        {
            var sum = 0;

            foreach(var number in numbers)
            sum +=number;

            return sum;
        }
    }



    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;    
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            {
                // Move(newLocation.X, newLocation.Y);

                if(newLocation == null)
                throw new ArgumentNullException("newLocation");
                
                Move(newLocation.X, newLocation.Y);
            }
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }


    }


    public  class Program
    {
         static void Main(string[] args)
         {
            //Demo for Method
           //  DemoMethod();

            // Demo for Params
             DemoParams();

         }


         public static void DemoMethod()
         {
            // var point = new Point(10, 20);
            // System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            // point.Move( 20, 30);
            // System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            
            // point.Move(new Point(40, 50));
            // System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            // Null check
           // point.Move(null);

            try
            {
                var point1 = new Point(10, 20);
                    point1.Move(null);

            }

            catch(Exception)
            {
                System.Console.WriteLine("Unexpected error occured");
            }
         }

         public static void DemoParams()
         {
            var Calculator = new Calculator();
            System.Console.WriteLine(Calculator.Add(1,2));
            System.Console.WriteLine(Calculator.Add(1,2,3));
            System.Console.WriteLine(Calculator.Add(1,2,3,4));
            System.Console.WriteLine(Calculator.Add(1,2,4,5,6,6));

         }
    }
}
