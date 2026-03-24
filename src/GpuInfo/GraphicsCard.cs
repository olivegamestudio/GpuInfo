using System.Management;

namespace GpuInfo;

public static class Hardware
{
	public static bool ContainsNvidia() => ContainsVendor("NVIDIA");

	public static bool ContainsAti() => ContainsVendor("ATI") || ContainsVendor("AMD");

	public static bool ContainsIntel() => ContainsVendor("Intel");

	public static bool ContainsVendor(string vendor)
	{
		using ManagementObjectSearcher searcher = new("SELECT Name FROM Win32_VideoController");

		foreach (ManagementBaseObject mo in searcher.Get())
		{
			string? name = mo["Name"]?.ToString();

			if (name is not null && name.Contains(vendor))
			{
				mo.Dispose();
				return true;
			}

			mo.Dispose();
		}

		return false;
	}
}
