#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _MI_SYSTEM_PTE_TYPE
    {
        [FieldOffset(0)]
        public _RTL_BITMAP_EX Bitmap;
        [FieldOffset(16)]
        public _RTL_BITMAP_EX TrackingBitmap;
        [FieldOffset(32)]
        public IntPtr BasePte;
        [FieldOffset(40)]
        public uint Flags;
        [FieldOffset(44)]
        public uint VaType;
        [FieldOffset(48)]
        public uint PteFailures;
        [FieldOffset(52)]
        public int SpinLock;
        [FieldOffset(56)]
        public ulong TotalSystemPtes;
        [FieldOffset(64)]
        public ulong Hint;
        [FieldOffset(72)]
        public ulong LowestBitEverAllocated;
        [FieldOffset(80)]
        public IntPtr CachedPtes;
        [FieldOffset(88)]
        public ulong TotalFreeSystemPtes;
    }
}