namespace Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int Length
        {
            get { return this.Length; }
            set { this.Length = value; }
        }
        public int Width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }
        public int Height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public double SurfaceArea(double length, double width, double height)
        {
            return 2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            return 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public double Volume(double length, double width, double height)
        {
            return this.length * this.height * this.width;
        }
        
    }
}
