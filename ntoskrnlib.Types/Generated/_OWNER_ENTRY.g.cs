using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _OWNER_ENTRY
{
    [FieldOffset(0)]
    public ulong OwnerThread;
    [FieldOffset(8)]
    public uint TableSize;
}
