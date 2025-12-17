#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _KSWAPPABLE_PAGE
    {
        [FieldOffset(0)]
        public IntPtr RegionStart;
        [FieldOffset(8)]
        public ulong TransitionLock;
        [FieldOffset(16)]
        public _KSWAPPABLE_PAGE_REF_COUNT LockCount;
        [FieldOffset(24)]
        public _MDL Mdl;
        [FieldOffset(72)]
        public ulong PageNumber;
    }
}