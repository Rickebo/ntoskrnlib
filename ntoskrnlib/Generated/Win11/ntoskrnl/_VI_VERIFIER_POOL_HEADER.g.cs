#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _VI_VERIFIER_POOL_HEADER
    {
        [FieldOffset(0)]
        public IntPtr VerifierPoolEntry;
    }
}