#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _TPP_CALLER
    {
        [FieldOffset(0)]
        public IntPtr ReturnAddress;
    }
}