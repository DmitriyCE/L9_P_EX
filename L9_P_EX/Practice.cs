using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_P_EX
{
    partial class Practice
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
        public struct DateTime
        {
            public int year;
            public int month;
            public int day;
            public int hours;
            public int minutes;
            public int seconds;
            public DateTime(int year = 1, int month = 1, int day = 1, int hours=0, int minutes=0, int seconds=0)
            {
                this.year = year;
                this.month = month;
                this.day = day;
                this.hours = hours;
                this.minutes= minutes;
                this.seconds= seconds;
            }
                void Deconstruct(out int year, out int month, out int day, out int hours, out int minutes, out int seconds)
            {
                year = this.year;
                month = this.month;
                day = this.day;
                hours = this.hours;
                minutes = this.minutes;
                seconds = this.seconds;
            }
        }
        
        public static void L9_P_EX_2_2()
        {
            DateTime date = new DateTime(2018, 7, 20, 18, 30, 25);
            int (year, month, day, hours, minutes, seconds) = date;
            Console.WriteLine(year);
        }
        ////DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25)





    }
}
