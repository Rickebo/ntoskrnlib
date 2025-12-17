#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HV_GET_BIN_CONTEXT
    {
        [FieldOffset(0)]
        public ushort OutstandingReference;
    }
}