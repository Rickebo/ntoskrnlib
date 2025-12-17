#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KAB_UM_PROCESS_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr Trees;
        [FieldOffset(8)]
        public uint TreeCount;
    }
}