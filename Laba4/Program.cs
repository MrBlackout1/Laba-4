using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        private static void Main()
        {
            Task1 Class = new Task1();
            Class.Show(new object[] { 1, new Point() {X = 0, Y = -1}, 3.1, 4f, "Hello World" });
        }

        // public static void Main()
        // {
        //     A robots = new A(new RobotAngel(), new RobotLaser(), new RobotGun());
        //     robots.Print();
        // }

        // public static void Main()
        // {
        //     Computer[] computer = new Computer[] { new GPU(), new CPU(), new Memory() };
        //     foreach (Computer components in computer)
        //         components.DebugPrint();
        // }
        //       public static void main()
        //    {
        //        console.write("уведiть лiцензiйний ключ: ");
        //        string key = console.readline();
        //        if (key.length == 0)
        //            applicationlicense.allowcommon();
        //        else if (key.length < 6)
        //            applicationlicense.allowtrial(key);
        //        else if (key.length > 5)
        //            applicationlicense.allowpro(key);
        //    }
        //}
    }
}