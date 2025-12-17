#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_CACHE_ALIGNED_ARRAY
    {
        [FieldOffset(0)]
        public int Lock;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public long SignedValue;
        [FieldOffset(0)]
        public _MI_CACHE_LINE CacheLinePadding;
    }
}