#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PO_FX_PERF_STATE_CHANGE
    {
        [FieldOffset(0)]
        public uint Set;
        [FieldOffset(8)]
        public uint StateIndex;
        [FieldOffset(8)]
        public ulong StateValue;
    }
}