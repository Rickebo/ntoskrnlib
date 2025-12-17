#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _COPY_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr SourceFileObject;
        [FieldOffset(8)]
        public long SourceFileOffset;
    }
}