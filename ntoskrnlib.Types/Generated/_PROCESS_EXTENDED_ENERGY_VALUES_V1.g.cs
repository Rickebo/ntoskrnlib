using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=440)]
public struct _PROCESS_EXTENDED_ENERGY_VALUES_V1
{
    [FieldOffset(0)]
    public _PROCESS_ENERGY_VALUES Base;
    [FieldOffset(272)]
    public _PROCESS_ENERGY_VALUES_EXTENSION Extension;
    [FieldOffset(432)]
    public ulong NpuWorkUnits;
}
