#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EXHANDLE
    {
        [FieldOffset(0)]
        public uint TagBits;
        [FieldOffset(0)]
        public uint Index;
        [FieldOffset(0)]
        public IntPtr GenericHandleOverlay;
        [FieldOffset(0)]
        public ulong Value;
    }
}