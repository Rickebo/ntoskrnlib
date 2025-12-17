#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _DMA_TRANSFER_CONTEXT_V1
    {
        [FieldOffset(0)]
        public int DmaState;
        [FieldOffset(4)]
        public uint TransferState;
        [FieldOffset(8)]
        public _WAIT_CONTEXT_BLOCK Wcb;
        [FieldOffset(80)]
        public IntPtr HalWcb;
    }
}