using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    enum version
    {
        Безкоштовна,
        Триальна,
        Платна
    }
    internal static class ApplicationLicense
    {
        static bool IsAllowKey()
        {
            Random r = new Random();
            if (r.Next(0, 100) < 50)
                return true;
            else
                return false;
        }
        static version userLicense = version.Безкоштовна;
        public static void AllowTrial(string keyLicense)
        {
            if (IsAllowKey())
                userLicense = version.Триальна;
            else
                Console.WriteLine("Неправильний ключ");
            PrintVersion();
        }
        public static void AllowCommon()
        {
            userLicense = version.Безкоштовна;
            PrintVersion();
        }
        public static void AllowPro(string keyLicense)
        {
            if (IsAllowKey())
                userLicense |= version.Платна;
            else
                Console.WriteLine("Неправильний ключ");
            PrintVersion();
        }        
        public static void PrintVersion()
        {
            Console.WriteLine($"Поточна версiя: {userLicense}");
        }
    }
}
