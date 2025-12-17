#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct FAST_ERESOURCE_LOCK_STATE
    {
        [FieldOffset(0)]
        public long Value;
        [FieldOffset(0)]
        public long Exclusive;
        [FieldOffset(0)]
        public long Conflict;
        [FieldOffset(0)]
        public long ShareCount;
    }
}