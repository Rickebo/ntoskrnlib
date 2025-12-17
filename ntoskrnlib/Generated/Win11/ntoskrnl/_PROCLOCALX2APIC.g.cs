#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROCLOCALX2APIC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public uint APICID;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint ACPIProcessorID;
    }
}