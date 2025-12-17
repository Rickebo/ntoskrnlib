#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PROCLOCALAPIC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public byte ACPIProcessorID;
        [FieldOffset(3)]
        public byte APICID;
        [FieldOffset(4)]
        public uint Flags;
    }
}