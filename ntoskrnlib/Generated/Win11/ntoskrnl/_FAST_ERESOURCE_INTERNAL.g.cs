#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _FAST_ERESOURCE_INTERNAL
    {
        [FieldOffset(0)]
        public FAST_ERESOURCE_LOCK_STATE LockWord;
        [FieldOffset(8)]
        public _KWAIT_CHAIN SharedWaiters;
        [FieldOffset(16)]
        public _KWAIT_CHAIN ExclusiveWaiters;
        [FieldOffset(24)]
        public byte Reserved;
        [FieldOffset(25)]
        public sbyte MiscFlags;
        [FieldOffset(26)]
        public ushort Flag;
        [FieldOffset(28)]
        public uint ResourceTimeoutCount;
        [FieldOffset(32)]
        public uint Reserved1;
        [FieldOffset(40)]
        public ulong CreatorBackTraceIndex;
        [FieldOffset(48)]
        public ulong SpinLock;
        [FieldOffset(56)]
        public uint NumberOfSharedWaiters;
        [FieldOffset(60)]
        public uint ContentionCount;
        [FieldOffset(64)]
        public _FAST_OWNER_ENTRY_INTERNAL ExclusiveOwnerEntry;
    }
}