#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _ETW_BUFFER_CONTEXT
    {
        [FieldOffset(0)]
        public byte ProcessorNumber;
        [FieldOffset(1)]
        public byte Alignment;
        [FieldOffset(0)]
        public ushort ProcessorIndex;
        [FieldOffset(2)]
        public ushort LoggerId;
    }
}