#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 6184)]
    public partial struct _WHEA_RECOVERY_CONTEXT
    {
        [FieldOffset(0)]
        public _unnamed_tag_ MemoryError;
        [FieldOffset(0)]
        public _unnamed_tag_ PmemError;
        [FieldOffset(16)]
        public ulong PartitionId;
        [FieldOffset(24)]
        public uint VpIndex;
        [FieldOffset(28)]
        public uint ErrorType;
        [FieldOffset(32)]
        public uint PageCount;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _WHEA_RECOVERY_CONTEXT_PAGE_INFO[] PageInfo;
    }
}