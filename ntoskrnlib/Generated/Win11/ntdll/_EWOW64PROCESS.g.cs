#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EWOW64PROCESS
    {
        [FieldOffset(0)]
        public IntPtr Peb;
        [FieldOffset(8)]
        public uint NtdllType;
    }
}