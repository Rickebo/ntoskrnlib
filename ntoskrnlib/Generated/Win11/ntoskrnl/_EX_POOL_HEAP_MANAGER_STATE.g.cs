#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 551296)]
    public partial struct _EX_POOL_HEAP_MANAGER_STATE
    {
        [FieldOffset(0)]
        public _RTLP_HP_HEAP_MANAGER HeapManager;
        [FieldOffset(14560)]
        public _EX_PUSH_LOCK PrivatePoolListLock;
        [FieldOffset(14568)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _LIST_ENTRY[] PrivatePools;
        [FieldOffset(14600)]
        public ulong PrivatePoolContextCookie;
        [FieldOffset(14608)]
        public uint NumberOfPools;
        [FieldOffset(14656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _EX_HEAP_POOL_NODE[] PoolNode;
        [FieldOffset(551232)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] SpecialHeaps;
    }
}