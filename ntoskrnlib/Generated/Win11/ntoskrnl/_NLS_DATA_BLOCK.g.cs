#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _NLS_DATA_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr AnsiCodePageData;
        [FieldOffset(8)]
        public IntPtr OemCodePageData;
        [FieldOffset(16)]
        public IntPtr UnicodeCaseTableData;
    }
}