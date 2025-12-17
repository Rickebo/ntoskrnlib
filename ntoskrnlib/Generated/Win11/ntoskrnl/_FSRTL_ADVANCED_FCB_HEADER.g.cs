#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _FSRTL_ADVANCED_FCB_HEADER
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(4)]
        public byte Flags;
        [FieldOffset(5)]
        public byte IsFastIoPossible;
        [FieldOffset(6)]
        public byte Flags2;
        [FieldOffset(7)]
        public byte Reserved;
        [FieldOffset(7)]
        public byte Version;
        [FieldOffset(8)]
        public IntPtr Resource;
        [FieldOffset(16)]
        public IntPtr PagingIoResource;
        [FieldOffset(24)]
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(32)]
        public _LARGE_INTEGER FileSize;
        [FieldOffset(40)]
        public _LARGE_INTEGER ValidDataLength;
        [FieldOffset(48)]
        public IntPtr FastMutex;
        [FieldOffset(56)]
        public _LIST_ENTRY FilterContexts;
        [FieldOffset(72)]
        public _EX_PUSH_LOCK PushLock;
        [FieldOffset(80)]
        public IntPtr FileContextSupportPointer;
        [FieldOffset(88)]
        public IntPtr Oplock;
        [FieldOffset(88)]
        public IntPtr ReservedForRemote;
        [FieldOffset(96)]
        public IntPtr AePushLock;
        [FieldOffset(104)]
        public uint BypassIoOpenCount;
        [FieldOffset(112)]
        public IntPtr ReservedContext;
    }
}