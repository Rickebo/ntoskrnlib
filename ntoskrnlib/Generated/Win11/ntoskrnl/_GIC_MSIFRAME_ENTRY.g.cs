#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _GIC_MSIFRAME_ENTRY
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Reserved1;
        [FieldOffset(4)]
        public uint Identifier;
        [FieldOffset(8)]
        public ulong PhysicalAddress;
        [FieldOffset(16)]
        public uint Flags;
        [FieldOffset(20)]
        public ushort SpiCount;
        [FieldOffset(22)]
        public ushort SpiBase;
    }
}