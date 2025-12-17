#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _VI_POOL_PAGE_HEADER
    {
        [FieldOffset(0)]
        public IntPtr NextPage;
        [FieldOffset(8)]
        public IntPtr VerifierEntry;
        [FieldOffset(16)]
        public ulong Signature;
    }
}