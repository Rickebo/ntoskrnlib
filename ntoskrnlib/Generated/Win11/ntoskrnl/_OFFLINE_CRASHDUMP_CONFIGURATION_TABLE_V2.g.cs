#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _OFFLINE_CRASHDUMP_CONFIGURATION_TABLE_V2
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint AbnormalResetOccurred;
        [FieldOffset(8)]
        public uint OfflineMemoryDumpCapable;
        [FieldOffset(16)]
        public _LARGE_INTEGER ResetDataAddress;
        [FieldOffset(24)]
        public uint ResetDataSize;
    }
}