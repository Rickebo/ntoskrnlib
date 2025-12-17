#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public partial struct _POP_PER_PROCESSOR_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr UncompressedData;
        [FieldOffset(8)]
        public IntPtr MappingVa;
        [FieldOffset(16)]
        public IntPtr XpressEncodeWorkspace;
        [FieldOffset(24)]
        public IntPtr CompressedDataBuffer;
        [FieldOffset(32)]
        public ulong CopyTicks;
        [FieldOffset(40)]
        public ulong CompressTicks;
        [FieldOffset(48)]
        public ulong BytesCopied;
        [FieldOffset(56)]
        public ulong PagesProcessed;
        [FieldOffset(64)]
        public ulong DecompressTicks;
        [FieldOffset(72)]
        public ulong ResumeCopyTicks;
        [FieldOffset(80)]
        public ulong SharedBufferTicks;
        [FieldOffset(88)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] BlockCountByMethod;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] DecompressTicksByMethod;
        [FieldOffset(144)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] DecompressSizeByMethod;
        [FieldOffset(160)]
        public uint CompressCount;
        [FieldOffset(164)]
        public uint HuffCompressCount;
    }
}