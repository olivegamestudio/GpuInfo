# GpuInfo

Lightweight GPU detection for .NET. Identify installed GPU vendors via WMI with zero heavyweight dependencies.

## Install

```
dotnet add package GpuInfo
```

## Usage

```csharp
using GpuInfo;

if (Hardware.ContainsNvidia())
{
    Console.WriteLine("NVIDIA GPU detected");
}

if (Hardware.ContainsAti())
{
    Console.WriteLine("AMD/ATI GPU detected");
}

// Check for any vendor by name
if (Hardware.ContainsVendor("Intel"))
{
    Console.WriteLine("Intel GPU detected");
}
```

## Why?

Some products need to detect the GPU vendor at runtime to apply driver-specific workarounds, toggle hardware acceleration, or log diagnostic information.

GpuInfo does one thing: tells you what GPU is installed. Fast, minimal, no surprises.

## How it works

Queries `Win32_VideoController` via WMI and matches the `Name` property against the requested vendor string (case-insensitive).

## Compatibility

| Target | Supported |
|---|---|
| .NET Framework 4.6.1+ | ✅ |
| .NET 6 / 8 / 10 | ✅ |
| .NET Standard 2.0 | ✅ |

> **Note:** WMI is Windows-only. These methods will throw on Linux/macOS. If you need cross-platform GPU detection, this isn't the package for you.

## License

MIT
