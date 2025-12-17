#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OBJECT_DUMP_CONTROL
    {
        [FieldOffset(0)]
        public IntPtr Stream;
        [FieldOffset(8)]
        public uint Detail;
    }
}