#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _GENERIC_MAPPING
    {
        [FieldOffset(0)]
        public uint GenericRead;
        [FieldOffset(4)]
        public uint GenericWrite;
        [FieldOffset(8)]
        public uint GenericExecute;
        [FieldOffset(12)]
        public uint GenericAll;
    }
}