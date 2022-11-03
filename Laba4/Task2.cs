using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class A
    {
        public B RobotAngel { get; set; }
        public B RobotLaser { get; set; }
        public B RobotGun { get; set; }
        public A(B r1)
        {
            RobotAngel = r1;
        }
        public A(B r1, B r2)
        {
            RobotAngel = r1;
            RobotLaser = r2;
        }
        public A(B r1, B r2, B r3)
        {
            RobotAngel = r1;
            RobotLaser = r2;
            RobotGun = r3;
        }
        public void Print()
        {
            if (RobotAngel != null)
            {
                Console.WriteLine("RobotAngel:");                
                RobotAngel.Print();
            }
            if (RobotLaser != null)
            {
                Console.WriteLine("RobotLaser:");                
                RobotLaser.Print();
            }
            if (RobotGun != null)
            {
                Console.WriteLine("RobotGun:");                
                RobotGun.Print();
            }
        }
    }
    
    internal class B
    {
        public virtual void Print() { }
    }

    internal class RobotAngel : B
    {
        public int Speed { get; set; } = 9;        
        public double Wings { get; set; } = 4;
        public string Color { get; set; } = "white";
        public override void Print()
        {
            Console.WriteLine($"Speed: {Speed}");            
            Console.WriteLine($"Wings: {Wings}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    internal class RobotLaser : B
    {
        public int Speed { get; set; } = 6;
        public double Lasers { get; set; } = 2;
        public string Color { get; set; } = "red";
        public override void Print()
        {
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Lasers: {Lasers}");
            Console.WriteLine($"Color: {Color}");
        }
    }
     
    internal class RobotGun : B
    {
        public double Speed { get; set; } = 4;
        public double Guns { get; set; } = 4;
        public string Color { get; set; } = "black";
        public override void Print()
        {
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Guns: {Guns}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
