using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemoryHelper;

public class MemoryHelper64
{
    private readonly Process _process;

    public MemoryHelper64(Process TargetProcess) =>
        _process = TargetProcess;

    public ulong GetBaseAddress(ulong StartingAddress) =>
        (ulong)_process.MainModule.BaseAddress.ToInt64() + StartingAddress;

    public byte[] ReadMemoryBytes(ulong MemoryAddress, int Bytes)
    {
        byte[] data = new byte[Bytes];
        ReadProcessMemory(_process.Handle, MemoryAddress, data, data.Length, IntPtr.Zero);
        return data;
    }

    public T ReadMemory<T>(ulong MemoryAddress)
    {
        byte[] data = ReadMemoryBytes(MemoryAddress, Marshal.SizeOf(typeof(T)));

        T t;
        GCHandle PinnedStruct = GCHandle.Alloc(data, GCHandleType.Pinned);
        try { t = (T)Marshal.PtrToStructure(PinnedStruct.AddrOfPinnedObject(), typeof(T)); }
        catch (Exception ex) { throw ex; }
        finally { PinnedStruct.Free(); }

        return t;
    }

    public bool WriteMemory<T>(ulong MemoryAddress, T Value)
    {
        int sz = ObjectType.GetSize<T>();
        byte[] data = ObjectType.GetBytes(Value);
        bool result = WriteProcessMemory(_process.Handle, MemoryAddress, data, sz, out IntPtr bw);
        return result && bw != IntPtr.Zero;
    }

    public void Close() =>
        CloseHandle(_process.Handle);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool ReadProcessMemory(
        IntPtr hProcess,
        ulong lpBaseAddress,
        byte[] lpBuffer,
        int nSize,
        IntPtr lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool WriteProcessMemory(
        IntPtr hProcess,
        ulong lpBaseAddress,
        byte[] lpBuffer,
        int nSize,
        out IntPtr lpNumberOfBytesWritten
        );

    [DllImport("kernel32.dll")]
    private static extern int CloseHandle(IntPtr hProcess);
}
