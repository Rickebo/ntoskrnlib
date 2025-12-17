#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ETW_LAST_ENABLE_INFO
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER EnableFlags;
        [FieldOffset(8)]
        public ushort LoggerId;
        [FieldOffset(10)]
        public byte Level;
        [FieldOffset(11)]
        public byte Enabled;
        [FieldOffset(11)]
        public byte InternalFlag;
    }
}