#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MMEXTEND_INFO
    {
        [FieldOffset(0)]
        public ulong CommittedSize;
        [FieldOffset(8)]
        public uint ReferenceCount;
    }
}