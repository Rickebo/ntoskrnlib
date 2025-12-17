#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_RESAVAIL_FAILURES
    {
        [FieldOffset(0)]
        public uint Wrap;
        [FieldOffset(4)]
        public uint NoCharge;
    }
}