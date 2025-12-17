#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KIST_BASE_FRAME
    {
        [FieldOffset(0)]
        public IntPtr KernelGsBase;
        [FieldOffset(8)]
        public IntPtr IstStack;
        [FieldOffset(16)]
        public ulong PreviousGsBase;
        [FieldOffset(24)]
        public ulong PreviousCr3;
        [FieldOffset(32)]
        public ulong IstPad;
        [FieldOffset(40)]
        public ulong Reserved;
    }
}