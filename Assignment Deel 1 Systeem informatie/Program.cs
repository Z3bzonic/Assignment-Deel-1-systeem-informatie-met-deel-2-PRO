// See https://aka.ms/new-console-template for more information
using System.IO;

bool is64bit = Environment.Is64BitOperatingSystem;
string pcname = Environment.MachineName;
int proccount = Environment.ProcessorCount;
string username = Environment.UserName;
long memory = Environment.WorkingSet;


if (is64bit)
{
    Console.WriteLine($"De gebruiker {username} heeft een 64 bit-systeem met \n{proccount} processoren\nTotaal {memory / 1000000.0} Gb aan geheugen \nOp machine {pcname}");
}
else {
    Console.WriteLine($"De gebruiker {username} heeft een 32 bit-systeem met \n{proccount} processoren\nTotaal {memory / 1000000.0} Gb aan geheugen \nOp machine {pcname}");
}
Console.WriteLine("Geef de harde schijf nummer in b.v.:\"1\" voor de C schijf onder standaard installaties");

int invoer= Convert.ToInt32(Console.ReadLine()); ;
while (invoer < 1)
{
    Console.WriteLine("Geef de harde schijf nummer in b.v.:\"1\" voor de C schijf onder standaard installaties");
    invoer = Convert.ToInt32(Console.ReadLine());
}
long totalsize = DriveInfo.GetDrives()[invoer -1].TotalSize;
Console.WriteLine($"De grootte van schijf {invoer} is {totalsize/100000000} Gb");