using LibCheckNeedToUpdate;
using Version = LibCheckNeedToUpdate.Version;

string v1, v2;
Console.WriteLine("Input current version: ");
v1 = Console.ReadLine();
Console.ReadKey();

Console.WriteLine("Input other version: ");
v2 = Console.ReadLine();
Console.ReadKey();

Version version = new Version(v1, v2);