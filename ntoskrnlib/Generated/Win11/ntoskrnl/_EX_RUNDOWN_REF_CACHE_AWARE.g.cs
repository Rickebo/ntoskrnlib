#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EX_RUNDOWN_REF_CACHE_AWARE
    {
        [FieldOffset(0)]
        public IntPtr RunRefs;
        [FieldOffset(8)]
        public IntPtr PoolToFree;
        [FieldOffset(16)]
        public uint RunRefSize;
        [FieldOffset(20)]
        public uint Number;
    }
}