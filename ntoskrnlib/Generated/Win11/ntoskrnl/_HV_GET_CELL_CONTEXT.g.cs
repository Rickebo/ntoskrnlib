#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HV_GET_CELL_CONTEXT
    {
        [FieldOffset(0)]
        public uint Cell;
        [FieldOffset(4)]
        public _HV_GET_BIN_CONTEXT BinContext;
    }
}