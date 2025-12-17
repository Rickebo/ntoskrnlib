#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KTIMER_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public _LIST_ENTRY Entry;
        [FieldOffset(24)]
        public _ULARGE_INTEGER Time;
    }
}