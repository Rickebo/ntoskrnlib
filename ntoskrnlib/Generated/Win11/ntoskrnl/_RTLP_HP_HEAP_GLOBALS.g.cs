#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _RTLP_HP_HEAP_GLOBALS
    {
        [FieldOffset(0)]
        public ulong HeapKey;
        [FieldOffset(8)]
        public ulong LfhKey;
        [FieldOffset(16)]
        public IntPtr FailureInfo;
        [FieldOffset(24)]
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData;
        [FieldOffset(40)]
        public uint Flags;
        [FieldOffset(40)]
        public uint CpuFeaturesChecked;
        [FieldOffset(40)]
        public uint ErmsSupported;
        [FieldOffset(40)]
        public uint BMI2Supported;
        [FieldOffset(64)]
        public ulong RandomSeed;
    }
}