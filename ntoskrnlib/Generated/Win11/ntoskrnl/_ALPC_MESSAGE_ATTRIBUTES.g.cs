#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ALPC_MESSAGE_ATTRIBUTES
    {
        [FieldOffset(0)]
        public uint AllocatedAttributes;
        [FieldOffset(4)]
        public uint ValidAttributes;
    }
}