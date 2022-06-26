using System;
using System.Text;
using System.Threading;
using SerialWombat;

namespace SW18AB_Cs_LQ_Ex01_Test
{
    class Program
    {
        static SerialWombatChip sw = new SerialWombatChip();
        static SerialWombatLiquidCrystal lcd0 = new SerialWombatLiquidCrystal(sw,4,5,0,1,2,3);
        static void Main(string[] args)
        {
            sw.begin("COM98");
            lcd0.begin(20, 4);  //  Put your Width and Height here
            for (int i = 0; i < 0x40 + 40; i += 4)
            {
               
                lcd0.command(0x80 | i);
                lcd0.write($"x{i:X2} ");
            }

        }
    }
}
