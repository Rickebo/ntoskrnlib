#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _KALPC_SECTION
    {
        [FieldOffset(0)]
        public IntPtr SectionObject;
        [FieldOffset(8)]
        public ulong Size;
        [FieldOffset(16)]
        public IntPtr HandleTable;
        [FieldOffset(24)]
        public IntPtr SectionHandle;
        [FieldOffset(32)]
        public IntPtr OwnerProcess;
        [FieldOffset(40)]
        public IntPtr OwnerPort;
        [FieldOffset(48)]
        public _unnamed_tag_ u1;
        [FieldOffset(52)]
        public uint NumberOfRegions;
        [FieldOffset(56)]
        public _LIST_ENTRY RegionListHead;
    }
}