#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _DBGKD_MANIPULATE_STATE64
    {
        [FieldOffset(0)]
        public uint ApiNumber;
        [FieldOffset(4)]
        public ushort ProcessorLevel;
        [FieldOffset(6)]
        public ushort Processor;
        [FieldOffset(8)]
        public int ReturnStatus;
        [FieldOffset(16)]
        public _unnamed_tag_ u;
    }
}