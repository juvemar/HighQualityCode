namespace ClassSize
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be a positive number!");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedSize(Figure figure, double rotationAngle)
        {
            double widthCos = Math.Abs(Math.Cos(rotationAngle)) * figure.Width;
            double heightSin = Math.Abs(Math.Sin(rotationAngle)) * figure.Height;
            double widthSin = Math.Abs(Math.Sin(rotationAngle)) * figure.Width;
            double heightCos = Math.Abs(Math.Cos(rotationAngle)) * figure.Height;

            double width = widthCos + heightSin;
            double height = widthSin + heightCos;

            return new Figure(width, height);
        }
    }
}