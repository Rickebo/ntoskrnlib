#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMPAGE_FILE_EXPANSION_FLAGS
    {
        [FieldOffset(0)]
        public byte PageFileNumber;
        [FieldOffset(1)]
        public byte Spare1;
        [FieldOffset(2)]
        public byte Spare2;
        [FieldOffset(3)]
        public byte IgnoreCurrentCommit;
        [FieldOffset(3)]
        public byte IncreaseMinimumSize;
        [FieldOffset(3)]
        public byte AttemptForCantExtend;
        [FieldOffset(3)]
        public byte UnusedSegmentDeletion;
        [FieldOffset(3)]
        public byte PageFileContract;
        [FieldOffset(3)]
        public byte NoWait;
        [FieldOffset(3)]
        public byte BeingProcessed;
        [FieldOffset(3)]
        public byte Spare3;
    }
}