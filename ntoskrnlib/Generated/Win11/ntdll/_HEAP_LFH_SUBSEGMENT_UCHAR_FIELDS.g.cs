#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS
    {
        [FieldOffset(0)]
        public byte PrivateFormat;
        [FieldOffset(0)]
        public byte Spare1;
        [FieldOffset(0)]
        public byte AllUCharBits;
    }
}