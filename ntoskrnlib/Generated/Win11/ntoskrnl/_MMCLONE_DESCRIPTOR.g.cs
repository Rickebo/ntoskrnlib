#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _MMCLONE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE CloneNode;
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(24)]
        public IntPtr StartingCloneBlock;
        [FieldOffset(32)]
        public IntPtr EndingCloneBlock;
        [FieldOffset(40)]
        public ulong NumberOfPtes;
        [FieldOffset(48)]
        public ulong NumberOfReferences;
        [FieldOffset(56)]
        public IntPtr CloneHeader;
        [FieldOffset(64)]
        public ulong NonPagedPoolQuotaCharge;
        [FieldOffset(80)]
        public _SLIST_ENTRY DeleteList;
        [FieldOffset(96)]
        public ulong NestingLevel;
    }
}