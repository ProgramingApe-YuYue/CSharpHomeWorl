using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test1
{
    public interface Shape//形状的接口，里面有求面积和判断形状是否合法的抽象方法
    {
        double area();
        bool shapeLegal();
        void toString();
    }
    public class Square:Shape
    {
       
       public Square(double length)
        {
            Length = length;
           
        }
       public Square(double length,double diagonal)//正方形的构造函数
        {
            Length = length;
        }
        public double Length { set; get; }
        
  
        public double area()
        {
            return Length * Length;

        }
        public bool shapeLegal()
        {
            return true;
        }
        public void toString()
        {
            Console.WriteLine($"shape:square,    area:{this.area()}");
        }
    }
    public class Rectangle:Shape
    {
        public Rectangle(double length,double width,double diagonal)//长方形的构造函数
        {
            Length = length;
            Width = width;
        }
        public Rectangle(double length, double width)//长方形的构造函数
        {
            Length = length;
            Width = width;
        }
        public double Length { set; get; }//长
        public double Width { set; get; }//宽
        public bool shapeLegal()
        {
            return true;
        }
        public double area()
        {
            if (shapeLegal())
                return Length * Width;
            else
                return -1;
        }
        public void toString()
        {
            Console.WriteLine($"shape:rectangle, area:{this.area()}");
        }
    }
    public class Triangle:Shape
    {
        public Triangle(double s1,double s2,double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public double side1 { set; get; }
        public double side2 { set; get; }
        public double side3 { set; get; }
        public bool shapeLegal()
        {
            if(side1 <=0 && side2 <= 0 && side3 <= 0)
            {
                
                return false;
            }
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side3 + side2 > side1) ;
        }
        public double area()
        {
            if (shapeLegal())
                return (1 / 4.0) * Math.Sqrt((side1 + side2 + side3) * (side1 + side2 - side3) * (side2 + side3 - side1) * (side1 + side3 - side2));
            else
                return -1;


        }
        public void toString()
        {
            Console.WriteLine($"shape:triangle,  area:{this.area()}");
        }

    }

    public class shapeFactory
    {
        
        public static Shape getShape(string shapeType)
        {
            switch(shapeType)
            {
                case "square":
                    return new Square(new Random(Guid.NewGuid().GetHashCode()).NextDouble()*10);
                case "rectangle":
                    return new Rectangle(new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10, new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10);
                case "triangle":
                    Triangle tri = new Triangle(new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10, new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10, new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10);
                    while(!tri.shapeLegal())
                    {
                        tri = new Triangle(new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10, new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10, new Random(Guid.NewGuid().GetHashCode()).NextDouble() * 10);
                    }
                    return tri;
                    
                default:
                    return null;
            }

        }
        public static Shape buildShape()
        {
            string[] shapeList = { "square", "rectangle", "triangle" };
            return getShape(shapeList[new Random(Guid.NewGuid().GetHashCode()).Next(0, 3)]);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一题：" );
            Square zheng = new Square(1,  Math.Sqrt(2.0));
            Console.WriteLine("正方形面积：" + zheng.area());
            Rectangle chang = new Rectangle(3.0, 4.0, 5.0);
            Console.WriteLine("长方形面积：" + chang.area());
            Triangle san = new Triangle(6.0, 6.0, 6.0);
            Console.WriteLine("三角形面积：" + san.area());
            Console.WriteLine("第二题：");
            Console.WriteLine("一下随机创建十个形状随机大小随机的图案并计算其面积之和");
            double areaSum = 0;
            Shape shape;
            for(int i=0;i<10;i++)
            {
                shape = shapeFactory.buildShape();
                areaSum += shape.area();
                shape.toString();
            }
            Console.WriteLine($"面积之和为{areaSum}");


            Console.Write("按任意键关闭");
            Console.ReadKey();

        }
        
    }
}
