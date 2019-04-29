using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_P_EX
{
    public static class Practice
    {
        public struct Coordinates
        {
            public double x;
            public double y;
            public double z;
            public Coordinates(double x=0.0, double y=0.0, double z=0.0)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void Deconstruct(out double x, out double y, out double z)
            {
                x = this.x;
                y = this.y;
                z = this.z;
            }
        }

        static Coordinates coord = new Coordinates(26,60.3,50);
        
        public static void L9_P_EX_1_2()
        {
            var (x, y, z) = coord;
            double vector =Math.Sqrt(x*x+y*y+z*z);
            Console.WriteLine(vector);
        }

        public static void L9_P_EX_2_2()
        {
            DateTime date = new DateTime();
            var (_, _, _, hours, minute, second) = date;
            Console.WriteLine($"{hours} {minute} {second}");
        }
        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hours, out int minute, out int second)
        {
            year = DateTime.Now.Year; 
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hours = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }





    }
}
