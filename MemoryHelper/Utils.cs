namespace MemoryHelper;

public static class Utils
{
    public static uint OffsetCalculator(MemoryHelper32 TargetMemory, uint BaseAddress, int[] Offsets)
    {
        var address = BaseAddress;
        foreach (uint offset in Offsets)
        {
            address = TargetMemory.ReadMemory<uint>(address) + offset;
        }
        return address;
    }

    public static ulong OffsetCalculator(MemoryHelper64 TargetMemory, ulong BaseAddress, int[] Offsets)
    {
        var address = BaseAddress;
        foreach (uint offset in Offsets)
        {
            address = TargetMemory.ReadMemory<ulong>(address) + offset;
        }
        return address;
    }
}