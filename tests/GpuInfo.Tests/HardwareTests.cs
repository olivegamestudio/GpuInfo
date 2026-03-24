namespace GpuInfo.Tests;

public class HardwareTests
{
	[Fact]
	public void Test1()
	{
		bool intel = Hardware.ContainsIntel();
		bool nvidia = Hardware.ContainsNvidia();
		bool ati = Hardware.ContainsAti();
	}
}
