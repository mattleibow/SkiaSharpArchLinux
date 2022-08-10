using System.Diagnostics;
using System.Runtime.InteropServices;
using SkiaSharp;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    Process.Start("uname", "-r");

Console.WriteLine($"Hello, {SKImageInfo.PlatformColorType} World!");
