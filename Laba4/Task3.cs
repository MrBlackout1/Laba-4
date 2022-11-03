using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Computer
    {
        public string GraphicCardModel { get; set; } = "Nvidia RTX 4090";
        public int GraphicCardMem { get; set; } = 24;
        public string CPUModel { get; set; } = "AMD Ryzen 7950x";
        public int CPUCores { get; set; } = 16;
        public int CPUThreads { get; set; } = 32;
        public int Ram { get; set; } = 32;
        public int SSD { get; set; } = 2000;
        public virtual void DebugPrint()
        {
            Debug.WriteLine($"Graphic Card Model: {GraphicCardModel}");
            Debug.WriteLine($"Graphic Card Memory (GB): {GraphicCardMem}");
            Debug.WriteLine($"CPU Model: {CPUModel}");
            Debug.WriteLine($"CPU Cores Amount: {CPUCores}");
            Debug.WriteLine($"CPU Threads Amount: {CPUThreads}");
            Debug.WriteLine($"Ram (GB): {Ram}");
            Debug.WriteLine($"SSD (GB): {SSD}");
        }
    }
   internal class GPU : Computer
    {
        public override void DebugPrint()
        {
            Debug.WriteLine($"Graphic Card Model: {GraphicCardModel}");
            Debug.WriteLine($"Graphic Card Memory (GB): {GraphicCardMem}");
        }
    }
    internal class CPU : Computer
    {
        public override void DebugPrint()
        {
            Debug.WriteLine($"CPU Model: {CPUModel}");
            Debug.WriteLine($"CPU Cores Amount: {CPUCores}");
            Debug.WriteLine($"CPU Threads Amount: {CPUThreads}");
        }
    }
    internal class Memory : Computer
    {
        public override void DebugPrint()
        {
            Debug.WriteLine($"Ram (GB): {Ram}");
            Debug.WriteLine($"SSD (GB): {SSD}");
        }
    }
}




