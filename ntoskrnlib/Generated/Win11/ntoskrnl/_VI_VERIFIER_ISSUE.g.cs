#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _VI_VERIFIER_ISSUE
    {
        [FieldOffset(0)]
        public ulong IssueType;
        [FieldOffset(8)]
        public IntPtr Address;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] Parameters;
    }
}