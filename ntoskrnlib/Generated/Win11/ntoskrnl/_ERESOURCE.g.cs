#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _ERESOURCE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY SystemResourcesList;
        [FieldOffset(16)]
        public IntPtr OwnerTable;
        [FieldOffset(24)]
        public short ActiveCount;
        [FieldOffset(26)]
        public ushort Flag;
        [FieldOffset(26)]
        public byte ReservedLowFlags;
        [FieldOffset(27)]
        public byte WaiterPriority;
        [FieldOffset(32)]
        public IntPtr SharedWaiters;
        [FieldOffset(40)]
        public IntPtr ExclusiveWaiters;
        [FieldOffset(48)]
        public _OWNER_ENTRY OwnerEntry;
        [FieldOffset(64)]
        public uint ActiveEntries;
        [FieldOffset(68)]
        public uint ContentionCount;
        [FieldOffset(72)]
        public uint NumberOfSharedWaiters;
        [FieldOffset(76)]
        public uint NumberOfExclusiveWaiters;
        [FieldOffset(80)]
        public sbyte MiscFlags;
        [FieldOffset(81)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved1;
        [FieldOffset(84)]
        public uint ResourceTimeoutCount;
        [FieldOffset(88)]
        public IntPtr Address;
        [FieldOffset(88)]
        public ulong CreatorBackTraceIndex;
        [FieldOffset(96)]
        public ulong SpinLock;
    }
}