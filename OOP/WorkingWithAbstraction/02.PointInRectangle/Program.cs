using System;
using System.Linq;

namespace _02.PointInRectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] rectanglePoints = input.Take(input.Length).Select(int.Parse).ToArray();

            int numberOfPoints = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(rectanglePoints);

            for (int i = 0; i < numberOfPoints; i++)
            {
                string[] inputPoints = Console.ReadLine().Split(' ');
                int[] points = inputPoints.Take(input.Length).Select(int.Parse).ToArray();
                Point point = new Point(points[0], points[1]);
                bool isInTheRectangle = rectangle.Contains(point);
                Console.WriteLine(isInTheRectangle); 
            }

            
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }

    class Rectangle
    {
        private int topLeftX;
        private int topLeftY;
        private int bottomRightX;
        private int bottomLeftY;

        public Rectangle(int[] points)
        {
            topLeftX = points[0];
            topLeftY = points[1];
            bottomRightX = points[2];
            bottomLeftY = points[3];
        }

        public bool Contains(Point point)
        {
            int pointX = point.getX();
            int pointY = point.getY();

            if (topLeftX <= pointX && topLeftY <= pointY && bottomRightX >= pointX && bottomLeftY >= pointY )
            {
                return true;
            }

            return false;
        }
    }
}
