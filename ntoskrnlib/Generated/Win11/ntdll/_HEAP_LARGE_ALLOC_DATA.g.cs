#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HEAP_LARGE_ALLOC_DATA
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE TreeNode;
        [FieldOffset(24)]
        public ulong VirtualAddress;
        [FieldOffset(24)]
        public ulong UnusedBytes;
        [FieldOffset(32)]
        public ulong ExtraPresent;
        [FieldOffset(32)]
        public ulong GuardPageCount;
        [FieldOffset(32)]
        public ulong GuardPageAlignment;
        [FieldOffset(32)]
        public ulong Spare;
        [FieldOffset(32)]
        public ulong AllocatedPages;
    }
}