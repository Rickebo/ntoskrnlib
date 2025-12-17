#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KPRCB_BPB_FEATURES
    {
        [FieldOffset(0)]
        public byte ClearOnIdle;
        [FieldOffset(0)]
        public byte Enabled;
        [FieldOffset(0)]
        public byte Smep;
        [FieldOffset(0)]
        public byte KCet;
        [FieldOffset(0)]
        public byte BhbFlushSequence;
        [FieldOffset(0)]
        public byte VerwOnIdle;
        [FieldOffset(0)]
        public byte FeaturesReserved;
        [FieldOffset(0)]
        public byte AllFlags;
    }
}