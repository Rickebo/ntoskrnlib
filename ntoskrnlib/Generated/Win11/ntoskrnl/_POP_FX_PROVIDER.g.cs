#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _POP_FX_PROVIDER
    {
        [FieldOffset(0)]
        public uint Index;
        [FieldOffset(4)]
        public byte Activating;
    }
}