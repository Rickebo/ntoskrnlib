#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CM_UOW_SET_SD_DATA
    {
        [FieldOffset(0)]
        public uint SecurityCell;
        [FieldOffset(8)]
        public IntPtr Hive;
    }
}