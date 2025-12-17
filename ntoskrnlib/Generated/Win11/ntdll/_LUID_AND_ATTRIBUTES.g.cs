#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _LUID_AND_ATTRIBUTES
    {
        [FieldOffset(0)]
        public _LUID Luid;
        [FieldOffset(8)]
        public uint Attributes;
    }
}