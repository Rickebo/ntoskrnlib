#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KPRCB_BPB_RETPOLINE_STATE
    {
        [FieldOffset(0)]
        public byte RunningNonRetpolineCode;
        [FieldOffset(0)]
        public byte IndirectCallsSafe;
        [FieldOffset(0)]
        public byte RetpolineEnabled;
        [FieldOffset(0)]
        public byte RetpolineStateReserved;
        [FieldOffset(0)]
        public byte AllFlags;
    }
}