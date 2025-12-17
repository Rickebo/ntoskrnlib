#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _DMA_FUNCTION_TABLE
    {
        [FieldOffset(0)]
        public IntPtr InitializeController;
        [FieldOffset(8)]
        public IntPtr ValidateRequestLineBinding;
        [FieldOffset(16)]
        public IntPtr QueryMaxFragments;
        [FieldOffset(24)]
        public IntPtr ProgramChannel;
        [FieldOffset(32)]
        public IntPtr ConfigureChannel;
        [FieldOffset(40)]
        public IntPtr FlushChannel;
        [FieldOffset(48)]
        public IntPtr HandleInterrupt;
        [FieldOffset(56)]
        public IntPtr ReadDmaCounter;
        [FieldOffset(64)]
        public IntPtr ReportCommonBuffer;
        [FieldOffset(72)]
        public IntPtr CancelTransfer;
    }
}