using System;
using System.Linq;
using System.Reflection;

namespace Class_Box
{
    public class StartUp
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
           
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length,width,height);

            Console.WriteLine(fields.Count());
            Console.WriteLine($"Surface Area - {box.SurfaceArea(length, width, height):F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea(length,width,height):F2}");
            Console.WriteLine($"Volume - {box.Volume(length,width,height):F2}");
        }
    }
}
