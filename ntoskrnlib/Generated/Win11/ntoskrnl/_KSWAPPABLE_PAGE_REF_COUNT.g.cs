#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KSWAPPABLE_PAGE_REF_COUNT
    {
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public ulong Resident;
        [FieldOffset(0)]
        public ulong RefCount;
    }
}