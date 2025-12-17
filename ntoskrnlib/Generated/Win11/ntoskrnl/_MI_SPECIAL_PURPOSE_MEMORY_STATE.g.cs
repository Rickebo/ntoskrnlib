#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_SPECIAL_PURPOSE_MEMORY_STATE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY TypesList;
        [FieldOffset(16)]
        public _LIST_ENTRY CacheEligibleList;
        [FieldOffset(0)]
        public IntPtr RegularMemoryParentPartitionObject;
        [FieldOffset(8)]
        public IntPtr SpecialPurposeMemoryParentHandle;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] Attributes;
        [FieldOffset(48)]
        public _EX_PUSH_LOCK Lock;
    }
}