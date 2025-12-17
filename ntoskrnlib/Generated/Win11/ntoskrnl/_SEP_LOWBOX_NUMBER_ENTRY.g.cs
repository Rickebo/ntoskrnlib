#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _SEP_LOWBOX_NUMBER_ENTRY
    {
        [FieldOffset(0)]
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry;
        [FieldOffset(24)]
        public long ReferenceCount;
        [FieldOffset(32)]
        public IntPtr PackageSid;
        [FieldOffset(40)]
        public uint LowboxNumber;
        [FieldOffset(48)]
        public IntPtr AtomTable;
    }
}