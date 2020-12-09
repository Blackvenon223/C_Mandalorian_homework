using System;

namespace MediumHomework
{



    abstract class GeometryFigure
    {

        protected abstract double S();

        public  void Print()
        {
            Console.WriteLine(ToString());
        }
       
    }


    class Rectangle : GeometryFigure
    {
        protected double Width { get; set; }
        protected double Length { get; set; }

        public Rectangle(double l, double w) { Length = l; Width = w; }

        public override string ToString()
        {
            return   $"Ширина >>>>> {Width.ToString()} Длина >>>> {Length.ToString()} Площадь >>>>> {S()}";
        }

        protected override double S()
        {

            return Width * Length;


        }



        class Square : Rectangle
        {
            public Square(double a) : base(a, 0)
            {
                this.Length = a;
            }


            protected override double S()
            {

                return Length * Length;

            }

            public override string ToString()
            {
                return   $"сторона >>>> {Length.ToString()} Площадь >>>>> {S()}";
            }

        }


        class Circle : GeometryFigure
        {
            protected double R;

            public Circle(double r) { R = r; }

            protected override double S()
            {

                return 3.14 * (R * R);

            }

            public override string ToString()
            {
                return   $"Радиус >>>> {R.ToString()} Площадь >>>>> {S()}";
            }
        }
    }


    class Task1
    {
        public static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(5,8);
            rec.Print();

        }
    }
}