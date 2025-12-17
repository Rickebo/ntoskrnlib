#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_CACHED_PTE
    {
        [FieldOffset(0)]
        public ulong GlobalTimeStamp;
        [FieldOffset(0)]
        public ulong PteIndex;
        [FieldOffset(0)]
        public ulong Long;
    }
}