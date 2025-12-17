#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _ETW_DECODE_CONTROL_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public _GUID Decode;
        [FieldOffset(24)]
        public _GUID Control;
        [FieldOffset(40)]
        public byte ConsumersNotified;
    }
}