using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MemoryHelper;

internal static class ObjectType
{
    public static int GetSize<T>() =>
        Marshal.SizeOf(typeof(T));

    public static byte[] GetBytes<T>(T Value)
    {
        return typeof(T).ToString() switch
        {
            "System.Single" => BitConverter.GetBytes((float)Convert.ChangeType(Value, typeof(float))),
            "System.Int32" => BitConverter.GetBytes((int)Convert.ChangeType(Value, typeof(int))),
            "System.Int64" => BitConverter.GetBytes((long)Convert.ChangeType(Value, typeof(long))),
            "System.Double" => BitConverter.GetBytes((double)Convert.ChangeType(Value, typeof(double))),
            "System.Byte" => BitConverter.GetBytes((byte)Convert.ChangeType(Value, typeof(byte))),
            "System.String" => Encoding.Unicode.GetBytes((string)Convert.ChangeType(Value, typeof(string))),
            _ => new byte[0],
        };
    }
}