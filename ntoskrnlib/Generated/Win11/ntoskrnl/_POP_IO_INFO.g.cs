#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _POP_IO_INFO
    {
        [FieldOffset(0)]
        public IntPtr DumpMdl;
        [FieldOffset(8)]
        public uint IoStatus;
        [FieldOffset(16)]
        public ulong IoStartCount;
        [FieldOffset(24)]
        public ulong IoBytesCompleted;
        [FieldOffset(32)]
        public ulong IoBytesInProgress;
        [FieldOffset(40)]
        public ulong RequestSize;
        [FieldOffset(48)]
        public _LARGE_INTEGER IoLocation;
        [FieldOffset(56)]
        public ulong FileOffset;
        [FieldOffset(64)]
        public IntPtr Buffer;
        [FieldOffset(72)]
        public byte AsyncCapable;
        [FieldOffset(80)]
        public ulong BytesToRead;
        [FieldOffset(88)]
        public uint Pages;
        [FieldOffset(96)]
        public ulong HighestChecksumIndex;
        [FieldOffset(104)]
        public ushort PreviousChecksum;
    }
}