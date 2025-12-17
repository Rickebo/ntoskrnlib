#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _KALPC_REGION
    {
        [FieldOffset(0)]
        public _LIST_ENTRY RegionListEntry;
        [FieldOffset(16)]
        public IntPtr Section;
        [FieldOffset(24)]
        public ulong Offset;
        [FieldOffset(32)]
        public ulong Size;
        [FieldOffset(40)]
        public ulong ViewSize;
        [FieldOffset(48)]
        public _unnamed_tag_ u1;
        [FieldOffset(52)]
        public uint NumberOfViews;
        [FieldOffset(56)]
        public _LIST_ENTRY ViewListHead;
        [FieldOffset(72)]
        public IntPtr ReadOnlyView;
        [FieldOffset(80)]
        public IntPtr ReadWriteView;
    }
}