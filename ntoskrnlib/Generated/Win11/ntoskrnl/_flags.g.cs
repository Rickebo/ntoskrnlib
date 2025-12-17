#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _flags
    {
        [FieldOffset(0)]
        public byte SmtSetsPresent;
        [FieldOffset(0)]
        public byte Fill;
    }
}