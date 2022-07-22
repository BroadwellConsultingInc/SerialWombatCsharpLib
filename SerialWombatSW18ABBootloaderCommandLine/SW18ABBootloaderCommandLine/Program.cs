// See https://aka.ms/new-console-template for more information

using SerialWombat;
using SerialWombatSW18ABBootloader;
using System.Threading;

SerialWombatChip swc = new SerialWombatChip();
SerialWombatSW18ABBootloaderClient bl = new SerialWombatSW18ABBootloaderClient(swc);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Serial Wombat 18AB Bootloader");
Console.WriteLine($"Connecting to Serial Wombat chip on {args[0]}, downloading file {args[1]}");
Console.WriteLine();
Console.WriteLine();
swc.begin(args[0]);
Console.WriteLine($"Serial Wombat Chip opened.  VCC: {swc.readSupplyVoltage_mV()}");
Console.WriteLine();
Console.WriteLine();
bl.bootload(args[1]);

int lastPct = -1;
string lastStatus = "";
while (bl.Bootloading)
{
    int newPct = (int)(bl.PercentDone * 100);
    if (lastStatus != bl.Status || newPct != lastPct)
    {
        Console.WriteLine($"{bl.Status}, {newPct}");
        lastPct = newPct;
        lastStatus = bl.Status;
        Thread.Sleep(10);
    }
}