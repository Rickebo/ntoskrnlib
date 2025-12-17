#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _PRIVATE_CACHE_MAP
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(0)]
        public _PRIVATE_CACHE_MAP_FLAGS Flags;
        [FieldOffset(4)]
        public uint ReadAheadMask;
        [FieldOffset(8)]
        public IntPtr FileObject;
        [FieldOffset(16)]
        public _LARGE_INTEGER FileOffset1;
        [FieldOffset(24)]
        public _LARGE_INTEGER BeyondLastByte1;
        [FieldOffset(32)]
        public _LARGE_INTEGER FileOffset2;
        [FieldOffset(40)]
        public _LARGE_INTEGER BeyondLastByte2;
        [FieldOffset(48)]
        public uint SequentialReadCount;
        [FieldOffset(52)]
        public uint ReadAheadLength;
        [FieldOffset(56)]
        public _LARGE_INTEGER ReadAheadOffset;
        [FieldOffset(64)]
        public _LARGE_INTEGER ReadAheadBeyondLastByte;
        [FieldOffset(72)]
        public ulong PrevReadAheadBeyondLastByte;
        [FieldOffset(80)]
        public ulong ReadAheadSpinLock;
        [FieldOffset(88)]
        public uint PipelinedReadAheadRequestSize;
        [FieldOffset(92)]
        public uint ReadAheadGrowth;
        [FieldOffset(96)]
        public _LIST_ENTRY PrivateLinks;
        [FieldOffset(112)]
        public IntPtr ReadAheadWorkItem;
    }
}