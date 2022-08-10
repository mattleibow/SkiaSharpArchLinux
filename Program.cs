using System.Diagnostics;
using System.Runtime.InteropServices;
using SkiaSharp;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
{
    Console.WriteLine(File.ReadAllText("/etc/os-release"));
    Process.Start("uname", "-r");
}

Console.WriteLine($"Hello, {SKImageInfo.PlatformColorType} World!");
