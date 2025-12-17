#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ULARGE_INTEGER
    {
        [FieldOffset(0)]
        public uint LowPart;
        [FieldOffset(4)]
        public uint HighPart;
        [FieldOffset(0)]
        public _unnamed_tag_ u;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}