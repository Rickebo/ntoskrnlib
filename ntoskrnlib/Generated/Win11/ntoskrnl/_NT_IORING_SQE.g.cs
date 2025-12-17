#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _NT_IORING_SQE
    {
        [FieldOffset(0)]
        public uint OpCode;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public ulong UserData;
        [FieldOffset(8)]
        public ulong PaddingUserDataForWow;
        [FieldOffset(16)]
        public _NT_IORING_OP_READ Read;
        [FieldOffset(16)]
        public _NT_IORING_OP_REGISTER_FILES RegisterFiles;
        [FieldOffset(16)]
        public _NT_IORING_OP_REGISTER_BUFFERS RegisterBuffers;
        [FieldOffset(16)]
        public _NT_IORING_OP_CANCEL Cancel;
        [FieldOffset(16)]
        public _NT_IORING_OP_WRITE Write;
        [FieldOffset(16)]
        public _NT_IORING_OP_FLUSH Flush;
        [FieldOffset(16)]
        public _NT_IORING_OP_READ_SCATTER ReadScatter;
        [FieldOffset(16)]
        public _NT_IORING_OP_WRITE_GATHER WriteGather;
        [FieldOffset(16)]
        public _NT_IORING_OP_RESERVED ReservedMaxSizePadding;
    }
}