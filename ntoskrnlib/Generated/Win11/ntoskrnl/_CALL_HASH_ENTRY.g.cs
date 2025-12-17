#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _CALL_HASH_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr CallersAddress;
        [FieldOffset(24)]
        public IntPtr CallersCaller;
        [FieldOffset(32)]
        public uint CallCount;
    }
}