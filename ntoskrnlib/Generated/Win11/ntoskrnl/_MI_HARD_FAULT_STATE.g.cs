#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_HARD_FAULT_STATE
    {
        [FieldOffset(0)]
        public IntPtr SwapPfn;
        [FieldOffset(8)]
        public _MI_STORE_INPAGE_COMPLETE_FLAGS StoreFlags;
    }
}