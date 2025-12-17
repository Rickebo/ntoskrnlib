#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public partial struct _ALPC_COMPLETION_LIST_HEADER
    {
        [FieldOffset(0)]
        public ulong StartMagic;
        [FieldOffset(8)]
        public uint TotalSize;
        [FieldOffset(12)]
        public uint ListOffset;
        [FieldOffset(16)]
        public uint ListSize;
        [FieldOffset(20)]
        public uint BitmapOffset;
        [FieldOffset(24)]
        public uint BitmapSize;
        [FieldOffset(28)]
        public uint DataOffset;
        [FieldOffset(32)]
        public uint DataSize;
        [FieldOffset(36)]
        public uint AttributeFlags;
        [FieldOffset(40)]
        public uint AttributeSize;
        [FieldOffset(64)]
        public _ALPC_COMPLETION_LIST_STATE State;
        [FieldOffset(72)]
        public uint LastMessageId;
        [FieldOffset(76)]
        public uint LastCallbackId;
        [FieldOffset(128)]
        public uint PostCount;
        [FieldOffset(192)]
        public uint ReturnCount;
        [FieldOffset(256)]
        public uint LogSequenceNumber;
        [FieldOffset(320)]
        public _RTL_SRWLOCK UserLock;
        [FieldOffset(328)]
        public ulong EndMagic;
    }
}