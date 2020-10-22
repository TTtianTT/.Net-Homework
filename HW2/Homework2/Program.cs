using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个形状：");
            String shape = Console.ReadLine();
            Console.WriteLine("输入准备生产的数量：");
            int num = Convert.ToInt32(Console.ReadLine());
            double GetAreaSum = 0;
            Shape[] shapeArray = Factory.produceShape(num, shape);
            for (int i = 0; i < num; i++)
            {
                GetAreaSum += shapeArray[i].GetArea();
            }
            GetAreaSum += shapeArray[0].area;
            Console.WriteLine(GetAreaSum);
        }
    }
    abstract class Shape
    {
        public double area;
        public abstract double GetArea();
        public abstract bool isLegal();
    }



    class Rectangle : Shape
    {
        public double width;
        public double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public override double GetArea()
        {
            if (this.isLegal() == true)
            {
                area = width * length;
            }
            else
            {
                area = 0;
            }

            return area;
        }

        public override bool isLegal()
        {
            return (this.width > 0 && this.length > 0);
        }
    }
    class Circle : Shape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            if (isLegal() == true)
            {
                area = radius * radius * 3.1415926;
            }
            else
            {
                area = 0;
            }
            return area;
        }

        public override bool isLegal()
        {
            return radius > 0;
        }
    }
    class Triangle : Shape
    {
        public double height;
        public double l;

        public Triangle(double height, double l)
        {
            this.height = height;
            this.l = l;
        }

        public override double GetArea()
        {
            if (isLegal() == true)
            {
                area = 0.5 * height * l;
            }
            else
            {
                area = 0;
            }
            return area;
        }


        public override bool isLegal()
        {
            return (height > 0 && l > 0);
        }
    }
    class Factory
    {
        public static Shape createShape(string shape)
        {
            Shape emptyShape = null;
            switch (shape)
            {
                case "R":
                    {
                        Random rm = new Random();
                        emptyShape = new Rectangle(rm.Next(1, 10), rm.Next(1, 10));
                        break;
                    }

                case "T":
                    {
                        Random rm = new Random();
                        emptyShape = new Triangle(rm.Next(1, 10), rm.Next(1, 10));
                        break;
                    }

                case "C":
                    {
                        Random rm = new Random();
                        emptyShape = new Circle(rm.Next(1, 10));
                        break;
                    }

            }
            return emptyShape;
        }
        public static Shape[] produceShape(int num, string shape)
        {
            Shape[] productsArray = new Shape[num];
            for (int i = 0; i < num; i++)
            {
                productsArray[i] = createShape(shape);
                Thread.Sleep(1);
            }
            return productsArray;
        }

    }

}

