#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1032)]
    public partial struct _CALL_PERFORMANCE_DATA
    {
        [FieldOffset(0)]
        public ulong SpinLock;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _LIST_ENTRY[] HashTable;
    }
}