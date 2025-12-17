#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _GIC_REDISTRIBUTOR
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public ulong DiscoveryRangeBaseAddress;
        [FieldOffset(12)]
        public uint DiscoveryRangeLength;
    }
}