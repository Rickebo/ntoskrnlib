#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _RTLP_RANGE_LIST_ENTRY
    {
        [FieldOffset(0)]
        public ulong Start;
        [FieldOffset(8)]
        public ulong End;
        [FieldOffset(16)]
        public _unnamed_tag_ Allocated;
        [FieldOffset(16)]
        public _unnamed_tag_ Merged;
        [FieldOffset(32)]
        public byte Attributes;
        [FieldOffset(33)]
        public byte PublicFlags;
        [FieldOffset(34)]
        public ushort PrivateFlags;
        [FieldOffset(40)]
        public _LIST_ENTRY ListEntry;
    }
}