#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _VI_POOL_ENTRY
    {
        [FieldOffset(0)]
        public _VI_POOL_PAGE_HEADER PageHeader;
        [FieldOffset(0)]
        public _VI_POOL_ENTRY_INUSE InUse;
        [FieldOffset(0)]
        public IntPtr NextFree;
    }
}