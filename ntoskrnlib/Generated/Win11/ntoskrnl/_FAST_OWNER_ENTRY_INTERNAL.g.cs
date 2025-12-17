#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _FAST_OWNER_ENTRY_INTERNAL
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr ThreadAddressAndDisowned;
        [FieldOffset(24)]
        public IntPtr LockAddress;
        [FieldOffset(32)]
        public int RecursiveReferenceCount;
        [FieldOffset(36)]
        public byte AbLockHandle;
        [FieldOffset(37)]
        public byte DynamicallyAllocated;
        [FieldOffset(37)]
        public byte CallerExclusive;
        [FieldOffset(37)]
        public byte CurrentlyWaitingShared;
        [FieldOffset(38)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Reserved;
    }
}