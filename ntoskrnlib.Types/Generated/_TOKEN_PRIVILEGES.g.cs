using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _TOKEN_PRIVILEGES
{
    [FieldOffset(0)]
    public uint PrivilegeCount;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Privileges;
}
