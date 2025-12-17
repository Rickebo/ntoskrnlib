#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _RTL_STACKDB_CONTEXT
    {
        [FieldOffset(0)]
        public _RTL_HASH_TABLE StackSegmentTable;
        [FieldOffset(16)]
        public _RTL_HASH_TABLE StackEntryTable;
        [FieldOffset(32)]
        public _RTL_SRWLOCK StackEntryTableLock;
        [FieldOffset(40)]
        public _RTL_SRWLOCK SegmentTableLock;
        [FieldOffset(48)]
        public IntPtr Allocate;
        [FieldOffset(56)]
        public IntPtr Free;
        [FieldOffset(64)]
        public IntPtr AllocatorContext;
    }
}