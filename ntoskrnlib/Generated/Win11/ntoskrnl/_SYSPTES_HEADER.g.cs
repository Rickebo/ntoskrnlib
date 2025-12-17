#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public partial struct _SYSPTES_HEADER
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _LIST_ENTRY[] ListHead;
        [FieldOffset(256)]
        public ulong Count;
        [FieldOffset(264)]
        public ulong NumberOfEntries;
        [FieldOffset(272)]
        public ulong NumberOfEntriesPeak;
    }
}