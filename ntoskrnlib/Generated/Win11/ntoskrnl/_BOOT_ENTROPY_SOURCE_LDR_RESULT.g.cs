#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _BOOT_ENTROPY_SOURCE_LDR_RESULT
    {
        [FieldOffset(0)]
        public uint SourceId;
        [FieldOffset(8)]
        public ulong Policy;
        [FieldOffset(16)]
        public uint ResultCode;
        [FieldOffset(20)]
        public int ResultStatus;
        [FieldOffset(24)]
        public ulong Time;
        [FieldOffset(32)]
        public uint EntropyLength;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] EntropyData;
    }
}