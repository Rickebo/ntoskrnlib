#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _OBJECT_REF_STACK_INFO
    {
        [FieldOffset(0)]
        public uint Sequence;
        [FieldOffset(4)]
        public ushort Index;
        [FieldOffset(6)]
        public ushort NumTraces;
        [FieldOffset(8)]
        public uint Tag;
    }
}