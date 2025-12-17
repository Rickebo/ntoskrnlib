#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public partial struct _MI_SYSTEM_NODE_NONPAGED_POOL
    {
        [FieldOffset(0)]
        public _MI_DYNAMIC_BITMAP DynamicBitMapNonPagedPool;
        [FieldOffset(72)]
        public int NonPagedPoolSpinLock;
        [FieldOffset(80)]
        public _MI_PAGE_CHAIN_HEAD CachedNonPagedPool;
        [FieldOffset(104)]
        public IntPtr NonPagedPoolFirstVa;
        [FieldOffset(112)]
        public IntPtr NonPagedPoolLastVa;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] OptimalZeroingAttribute;
        [FieldOffset(184)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] ZeroCostCounts;
        [FieldOffset(376)]
        public IntPtr SystemNodeInformation;
    }
}