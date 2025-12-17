#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_DRIVER_VA
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public IntPtr PointerPte;
        [FieldOffset(16)]
        public _RTL_BITMAP BitMap;
        [FieldOffset(32)]
        public uint Hint;
        [FieldOffset(36)]
        public uint Flags;
        [FieldOffset(40)]
        public _RTL_BITMAP PageTableCommitmentBitMap;
    }
}