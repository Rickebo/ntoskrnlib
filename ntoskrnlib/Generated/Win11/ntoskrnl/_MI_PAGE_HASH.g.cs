#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_PAGE_HASH
    {
        [FieldOffset(0)]
        public uint HashValue;
        [FieldOffset(4)]
        public uint PageFileOffset;
        [FieldOffset(8)]
        public IntPtr OwningPte;
    }
}