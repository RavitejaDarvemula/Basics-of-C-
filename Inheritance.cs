using System;

namespace Practice
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    //interface
    public interface PaintCost
    {
        int getCost(int area);
    }

    class Rectt : Shape,PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Rectt Rect = new Rectt();
            int area;

            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total Cost:{0}", Rect.getCost(area));
        }
    }
}