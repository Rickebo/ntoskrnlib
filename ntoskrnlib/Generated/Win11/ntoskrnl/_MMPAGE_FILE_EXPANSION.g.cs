#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _MMPAGE_FILE_EXPANSION
    {
        [FieldOffset(0)]
        public IntPtr Segment;
        [FieldOffset(8)]
        public _LIST_ENTRY DereferenceList;
        [FieldOffset(24)]
        public IntPtr Partition;
        [FieldOffset(32)]
        public ulong RequestedExpansionSize;
        [FieldOffset(40)]
        public ulong ActualExpansion;
        [FieldOffset(48)]
        public _KEVENT Event;
        [FieldOffset(72)]
        public int InProgress;
        [FieldOffset(76)]
        public _unnamed_tag_ u1;
        [FieldOffset(80)]
        public IntPtr ActiveEntry;
    }
}