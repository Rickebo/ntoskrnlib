#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS
    {
        [FieldOffset(0)]
        public byte FRUId;
        [FieldOffset(0)]
        public byte FRUText;
        [FieldOffset(0)]
        public byte Reserved;
        [FieldOffset(0)]
        public byte AsUCHAR;
    }
}