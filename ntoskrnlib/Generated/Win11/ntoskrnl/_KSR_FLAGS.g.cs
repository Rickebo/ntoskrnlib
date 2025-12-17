#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KSR_FLAGS
    {
        [FieldOffset(0)]
        public uint MpwrResume;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULong;
    }
}