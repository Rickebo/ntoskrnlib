#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_TRIAGE_DUMP_DATA
    {
        [FieldOffset(0)]
        public ulong BadPageCount;
        [FieldOffset(8)]
        public uint BadPagesDetected;
        [FieldOffset(12)]
        public int ZeroedPageSingleBitErrorsDetected;
        [FieldOffset(16)]
        public int ScrubPasses;
        [FieldOffset(20)]
        public int ScrubBadPagesFound;
        [FieldOffset(24)]
        public uint PageHashErrors;
        [FieldOffset(32)]
        public ulong FeatureBits;
        [FieldOffset(40)]
        public uint TimeZoneId;
        [FieldOffset(48)]
        public _MI_FLAGS Flags;
        [FieldOffset(56)]
        public IntPtr VsmConnection;
    }
}