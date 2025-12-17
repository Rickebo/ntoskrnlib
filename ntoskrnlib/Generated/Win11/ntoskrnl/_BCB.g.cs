#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _BCB
    {
        [FieldOffset(0)]
        public _MBCB Dummy;
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public byte Dirty;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public uint ByteLength;
        [FieldOffset(8)]
        public _LARGE_INTEGER FileOffset;
        [FieldOffset(16)]
        public _LIST_ENTRY BcbLinks;
        [FieldOffset(32)]
        public _LARGE_INTEGER BeyondLastByte;
        [FieldOffset(40)]
        public _LARGE_INTEGER OldestLsn;
        [FieldOffset(48)]
        public _LARGE_INTEGER NewestLsn;
        [FieldOffset(56)]
        public IntPtr Vacb;
        [FieldOffset(64)]
        public uint PinCount;
        [FieldOffset(72)]
        public _ERESOURCE Resource;
        [FieldOffset(176)]
        public IntPtr SharedCacheMap;
        [FieldOffset(184)]
        public IntPtr BaseAddress;
    }
}