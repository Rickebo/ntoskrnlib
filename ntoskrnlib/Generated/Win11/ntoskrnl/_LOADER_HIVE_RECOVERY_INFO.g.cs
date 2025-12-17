#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _LOADER_HIVE_RECOVERY_INFO
    {
        [FieldOffset(0)]
        public uint Recovered;
        [FieldOffset(0)]
        public uint LegacyRecovery;
        [FieldOffset(0)]
        public uint SoftRebootConflict;
        [FieldOffset(0)]
        public uint MostRecentLog;
        [FieldOffset(0)]
        public uint LoadedFromSnapshot;
        [FieldOffset(4)]
        public uint Spare;
        [FieldOffset(8)]
        public uint LogNextSequence;
        [FieldOffset(12)]
        public uint LogMinimumSequence;
        [FieldOffset(16)]
        public uint LogCurrentOffset;
    }
}